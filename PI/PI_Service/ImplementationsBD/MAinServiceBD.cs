using PI_Models;
using PI_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.ImplementationsBD
{
    public class MainServiceBD : IMainService
    {
        private PiDbContext context;

        public MainServiceBD(PiDbContext context)
        {
            this.context = context;
        }

        public User Author(string login, string password)
        {
            var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (user == null)
            {
                throw new Exception("Введен неверный логин/пароль");
            }
            return user;
        }
    }
}
