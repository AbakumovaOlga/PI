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
    public class SizeServiceBD : ISizeService
    {
        private PiDbContext context;

        public SizeServiceBD(PiDbContext context)
        {
            this.context = context;
        }

        public void CreateSize(SizeBM model)
        {
            Size element = context.Sizes.FirstOrDefault(rec => rec.Name == model.Name);
            if (element != null)
            {
                throw new Exception("Уже есть такой размер");
            }
            context.Sizes.Add(new Size
            {
                Name = model.Name
            });
            context.SaveChanges();
        }

        public void DelSize(SizeBM model)
        {
            throw new NotImplementedException();
        }

        public SizeBM GetElement(int id)
        {
            Size element = context.Sizes.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new SizeBM
                {
                    Id = element.Id,
                    Name = element.Name
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<SizeBM> GetList()
        {
            List<SizeBM> result = context.Sizes
                .Select(rec => new SizeBM
                {
                    Id = rec.Id,
                    Name = rec.Name
                })
                .ToList();
            return result;
        }

        public void UpdSize(SizeBM model)
        {
            throw new NotImplementedException();
        }
    }
}
