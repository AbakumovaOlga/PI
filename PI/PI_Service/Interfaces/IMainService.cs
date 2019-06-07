using PI_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.Interfaces
{
    public interface IMainService
    {
         User Author(string login, string password);
    }
}
