using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.BindingModels
{
    public class MaterialOrderBM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int MaterialId { get; set; }
        public int OrderId { get; set; }
    }
}
