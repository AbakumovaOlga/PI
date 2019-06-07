using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Models
{
   public class Buy
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey("BuyId")]
        public virtual List<MaterialBuy> MaterialBuys { get; set; }
    }
}
