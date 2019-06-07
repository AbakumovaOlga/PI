using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.BindingModels
{
   public class MaterialBM
    {
        public int Id { set; get; }

        public int SizeId { set; get; }
        public int TypeId { set; get; }

        public double Price { set; get; }

        public string Name { set; get; }

        public virtual List<MaterialOrderBM> MaterialOrders { get; set; }
      //  public virtual List<MaterialBuyBM> MaterialBuys { get; set; }
    }
}
