using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.BindingModels
{
    public class UserBM
    {
        public int Id { set; get; }

        public string Login { set; get; }

        public string Password { set; get; }

        public string Name { set; get; }
    }
}
