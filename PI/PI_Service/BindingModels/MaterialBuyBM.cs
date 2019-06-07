using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.BindingModels
{
   public  class MaterialBuyBM
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public string Name { get; set; }

        public int MaterialId { get; set; }
        public int BuyId { get; set; }
    }
}
