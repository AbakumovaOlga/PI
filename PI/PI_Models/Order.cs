using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Models
{
    public class Order
    {
        public int Id { set; get; }

        public OrderStatus Status { get; set; }

        public double Summa { get; set; }

        public string Customer { get; set; }

        public int? UserId { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime? DateFinish { get; set; }

        [ForeignKey("OrderId")]
        public virtual List<MaterialOrder> MaterialOrders { get; set; }

        public virtual User User { get; set; }
    }
}
