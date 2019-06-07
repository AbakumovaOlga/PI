using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.BindingModels
{
   public class BuyBM
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public virtual List<MaterialBuyBM> MaterialBuys { get; set; }
    }
}
