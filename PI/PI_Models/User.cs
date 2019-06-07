using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Models
{
    public class User
    {
        public int Id { set; get; }

        public string Login { set; get; }

        public string Password { set; get; }

        public string Name { set; get; }

        [ForeignKey("UserId")]
        public virtual List<Order> Orders { get; set; }
    }
}
