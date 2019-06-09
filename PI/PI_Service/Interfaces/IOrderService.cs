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

        List<OrderBM> GetListSatus(OrderStatus status);

        void TakeOrderInWork(int id);

        void FinishOrder(int id);

        void PayOrder(int id);

        int CountOst(int materialId);

        OrderStatus GetStatus(int id);
    }
}
