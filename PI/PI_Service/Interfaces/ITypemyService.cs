using PI_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.Interfaces
{
   public  interface ITypemyService
    {
        void CreateTypemy(TypemyBM model);

        void UpdTypemy(TypemyBM model);

        void DelTypemy(TypemyBM model);

        TypemyBM GetElement(int id);

        List<TypemyBM> GetList();
    }
}
