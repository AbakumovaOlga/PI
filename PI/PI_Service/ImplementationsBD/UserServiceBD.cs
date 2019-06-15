using PI_Models;
using PI_Service.BindingModels;
using PI_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.ImplementationsBD
{
    public class UserServiceBD : IUserService
    {
        private PiDbContext context;

        public UserServiceBD(PiDbContext context)
        {
            this.context = context;
        }

        public void CreateUser(User model)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Login == model.Login);
            if (element != null)
            {
                throw new Exception("Уже есть сотрудник с таким login");
            }
            context.Users.Add(new User
            {
                Login = model.Login,
                Password = model.Password,
                Name = model.Name
            });
            context.SaveChanges();
        }

        public void DelUser(User model)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Users.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public int GetCountOrders(int id)
        {
            List<OrderBM> orders = context.Orders
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
                }).Where(recU=> recU.UserId==id&recU.Status!=0)
                .ToList();
            

            return orders.Count;
        }

        public User GetElement(int id)
        {
            User element = context.Users.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new User
                {
                    Id = element.Id,
                    Login = element.Login,
                    Password = element.Password,
                    Name = element.Name
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<UserBM> GetList()
        {
            List<UserBM> result = context.Users
                 .Select(rec => new UserBM
                 {
                     Id = rec.Id,
                     Login = rec.Login,
                     Password = rec.Password,
                     Name = rec.Name
                 })
                 .ToList();
            return result;
        }

        public void UpdUser(User model)
        {
            throw new NotImplementedException();
        }
    }
}
