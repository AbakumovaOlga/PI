using PI_Models;
using PI_Service.BindingModels;
using PI_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.ImplementationsBD
{
   public  class BuyServiceBD :IBuyService
    {
        private PiDbContext context;

        public BuyServiceBD(PiDbContext context)
        {
            this.context = context;
        }

        public void CreateBuy(BuyBM model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {

                    Buy element = new Buy
                    {
                        Date = model.Date

                    };
                    context.Buys.Add(element);
                    context.SaveChanges();


                    foreach (var MaterialBuy in model.MaterialBuys)
                    {
                        context.MaterialBuys.Add(new MaterialBuy
                        {
                            BuyId = element.Id,
                            MaterialId = MaterialBuy.MaterialId,
                            Count = MaterialBuy.Count
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

        public List<MaterialBuyBM> GetList()
        {

            List<MaterialBuyBM> result = context.MaterialBuys
               .Select(rec => new MaterialBuyBM
               {
                   Id = rec.Id,
                   Count=rec.Count,
                   MaterialId=rec.MaterialId
               })
               .ToList();
            return result;
        }
    }
}
