using PI_Models;
using PI_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.Interfaces
{
    public interface IOrderService
    {
        void CreateOrder(OrderBM model);

        void DelOrder(int id);

        List<OrderBM> GetList();

        Order GetOrder(int id);
        List<MaterialOrderBM> GetOrderMaterials(int id);

        List<OrderBM> GetListSatus(OrderStatus status);

        void TakeOrderInWork(int id, int userId);

        void FinishOrder(int id);

        void PayOrder(int id);

        int CountOst(int materialId);

        double CountSum(List<MaterialOrderBM> MaterialOrders);

        OrderStatus GetStatus(int id);
    }
}
