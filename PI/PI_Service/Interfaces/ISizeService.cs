using PI_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.Interfaces
{
    public interface ISizeService
    {
        void CreateSize(SizeBM model);

        void UpdSize(SizeBM model);

        void DelSize(SizeBM model);

        SizeBM GetElement(int id);

        List<SizeBM> GetList();
    }
}
