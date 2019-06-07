using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Models
{
    public class MaterialBuy
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public int MaterialId { get; set; }
        public int BuyId { get; set; }

        public virtual Material Material { get; set; }
        public virtual Buy Buy { get; set; }

        
    }
}
