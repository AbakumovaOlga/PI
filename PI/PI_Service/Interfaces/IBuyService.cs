using PI_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.Interfaces
{
   public  interface IBuyService
    {
        void CreateBuy(BuyBM model);

        List<MaterialBuyBM> GetList();

        void DelBuy(BuyBM model);
    }
}
