using PI_Models;
using PI_Service.BindingModels;
using PI_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.ImplementationsBD
{
    public class OrderServiceBD : IOrderService
    {
        private PiDbContext context;

        public OrderServiceBD(PiDbContext context)
        {
            this.context = context;
        }

        public void CreateOrder(OrderBM model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Order element = new Order
                    {
                        Id = model.Id,
                        Customer = model.Customer,
                        Status = model.Status,
                        DateCreate = model.DateCreate,
                        DateFinish = model.DateFinish,
                        UserId = model.UserId
                    };
                    context.Orders.Add(element);
                    context.SaveChanges();
                  
                    // добавляем компоненты
                    foreach (var materialOrder in model.MaterialOrders)
                    {
                        context.MaterialOrders.Add(new MaterialOrder
                        {
                            OrderId = element.Id,
                            MaterialId = materialOrder.MaterialId
                        });
                        context.SaveChanges();
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void DelOrder(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Order element = context.Orders.FirstOrDefault(rec => rec.Id == id);
                    if (element != null)
                    {
                        // удаяем записи по компонентам при удалении заказа
                        context.MaterialOrders.RemoveRange(
                                            context.MaterialOrders.Where(rec => rec.OrderId == id));
                        context.Orders.Remove(element);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Элемент не найден");
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void FinishOrder(int id)
        {
            Order element = context.Orders.FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Status = OrderStatus.Готов;
            context.SaveChanges();
        }

        public List<OrderBM> GetList()
        {
            List<OrderBM> result = context.Orders
                 .Select(rec => new OrderBM
                 {
                     Id = rec.Id,
                     Customer = rec.Customer,
                     Status = rec.Status,
                     StatusString = rec.Status.ToString(),
                     Summa = rec.Summa,
                     DateCreate = rec.DateCreate,
                     DateFinish = rec.DateFinish,
                     UserId = rec.UserId,
                     MaterialOrders = context.MaterialOrders
                     .Where(recMO => recMO.OrderId == rec.Id)
                     .Select(recMO => new MaterialOrderBM
                     {
                         Id = recMO.Id,
                         MaterialId = recMO.MaterialId,
                         OrderId=recMO.OrderId
                     }).ToList()
                 })
                 .ToList();
            return result;
        }

        public void PayOrder(int id)
        {
            Order element = context.Orders.FirstOrDefault(rec => rec.Id == id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Status = OrderStatus.Оплачен;
            context.SaveChanges();
        }

        public void TakeOrderInWork(int id)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Order element = context.Orders.FirstOrDefault(rec => rec.Id == id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                    List<MaterialOrderBM> MaterialOrders = context.MaterialOrders.Select(rec => new MaterialOrderBM
                    {
                        Id = rec.Id,
                        MaterialId = rec.MaterialId,
                        OrderId = rec.OrderId
                    }).Where(rec => rec.OrderId == id).ToList();

                    foreach (var materialOrder in MaterialOrders)
                    {
                        if (CountOst(materialOrder.MaterialId) > 0)
                        {
                            context.MaterialOrders.Add(new MaterialOrder
                            {
                                OrderId = element.Id,
                                MaterialId = materialOrder.MaterialId
                            });
                            context.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Недостаточно материала");
                        }
                    }
                    transaction.Commit();

                    element.UserId = element.UserId;
                    element.DateFinish = DateTime.Now;
                    element.Status = OrderStatus.Выполняется;
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public int CountOst(int materialId)
        {
            int ost = 0; //контрольное значение

            //считаем покупки
            List<MaterialBuyBM> materialBuys = context.MaterialBuys.Select(rec => new MaterialBuyBM
            {
                Id = rec.Id,
                MaterialId = rec.MaterialId,
                Count=rec.Count
            }).Where(rec => rec.MaterialId == materialId).ToList();


            foreach(var materialBuy in materialBuys)
            {
                ost += materialBuy.Count;
            }


            //считаем расходы
            List<MaterialOrderBM> materialOrders = context.MaterialOrders.Select(rec => new MaterialOrderBM
            {
                Id = rec.Id,
                MaterialId = rec.MaterialId,
                OrderId=rec.OrderId
            }).Where(rec => rec.MaterialId == materialId).ToList();

            foreach (var materialOrder in materialOrders)
            {
                Order order = context.Orders.FirstOrDefault(rec => rec.Id == materialOrder.OrderId);
                if (order.Status != 0)
                {
                    ost--;
                }
            }


            return ost;
        }

        public List<OrderBM> GetListSatus(OrderStatus status)
        {
            List<OrderBM> result = context.Orders
                  .Select(rec => new OrderBM
                  {
                      Id = rec.Id,
                      Customer = rec.Customer,
                      Status = rec.Status,
                      StatusString = rec.Status.ToString(),
                      Summa = rec.Summa,
                      DateCreate = rec.DateCreate,
                      DateFinish = rec.DateFinish,
                      UserId = rec.UserId
                  }).Where(rec=>rec.Status==status)
                  .ToList();
            return result;
        }

        public OrderStatus GetStatus(int id)
        {
            Order order = context.Orders.FirstOrDefault(rec => rec.Id == id);

            return order.Status;

        }
    }
}
