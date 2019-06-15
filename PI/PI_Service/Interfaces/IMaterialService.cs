using PI_Service.BindingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.Interfaces
{
    public interface IMaterialService
    {
        void CreateMaterial(MaterialBM model);

        void UpdMaterial(MaterialBM model);

        void DelMaterial(MaterialBM model);

        MaterialBM GetElement(int id);

        List<MaterialBM> GetList();

        List<MaterialBM> GetListSize(int id);


        List<MaterialOnStockBM> GetListOnStock();

        bool ListShop(string fileName);
    }
}
