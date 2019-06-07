using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Models
{
    public class Material
    {
        public int Id { set; get; }

        public double Price { set; get; }


        public int SizeId { set; get; }

        public int TypeId { set; get; }


        public virtual Typemy Typemy { get; set; }

        public virtual Size Size { get; set; }


        [ForeignKey("MaterialId")]
        public virtual List<MaterialOrder> MaterialOrders { get; set; }

        [ForeignKey("MaterialId")]
        public virtual List<MaterialBuy> MaterialBuys { get; set; }
    }
}
