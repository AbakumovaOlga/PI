using PI_Models;
using PI_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.Interfaces
{
    public interface IUserService
    {
        void CreateUser(User model);

        void UpdUser(User model);

        void DelUser(User model);

        List<UserBM> GetList();

        User GetElement(int id);

        int GetCountOrders(int id);
    }
}
