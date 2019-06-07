using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Models
{
   public class MaterialOrder
    {
        public int Id { get; set; }

        public int MaterialId { get; set; }
        public int OrderId { get; set; }

        public virtual Material Material { get; set; }
        public virtual Order Order { get; set; }
    }
}
