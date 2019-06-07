using PI_Models;
using PI_Service.BindingModels;
using PI_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.ImplementationsBD
{
  public  class TypemyServiceBD:ITypemyService
    {
        private PiDbContext context;

        public TypemyServiceBD(PiDbContext context)
        {
            this.context = context;
        }

        public void CreateTypemy(TypemyBM model)
        {
            Typemy element = context.Typemys.FirstOrDefault(rec => rec.Name == model.Name);
            if (element != null)
            {
                throw new Exception("Уже есть такой размер");
            }
            context.Typemys.Add(new Typemy
            {
                Name = model.Name
            });
            context.SaveChanges();
        }

        public void DelTypemy(TypemyBM model)
        {
            throw new NotImplementedException();
        }

        public TypemyBM GetElement(int id)
        {
            Typemy element = context.Typemys.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new TypemyBM
                {
                    Id = element.Id,
                    Name = element.Name
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<TypemyBM> GetList()
        {
            List<TypemyBM> result = context.Typemys
               .Select(rec => new TypemyBM
               {
                   Id = rec.Id,
                   Name = rec.Name
               })
               .ToList();
            return result;
        }

        public void UpdTypemy(TypemyBM model)
        {
            throw new NotImplementedException();
        }
    }
}
