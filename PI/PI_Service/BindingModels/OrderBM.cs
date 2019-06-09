using PI_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.BindingModels
{
    public class OrderBM
    {
        public int Id { set; get; }

        public OrderStatus Status { get; set; }

        public string StatusString { get; set; }

        public double Summa { get; set; }

        public string Customer { get; set; }

        public int? UserId { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime? DateFinish { get; set; }
        
        public virtual List<MaterialOrderBM> MaterialOrders { get; set; }
        
    }
}
