﻿using PI_Models;
using PI_Service.BindingModels;
using PI_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Service.ImplementationsBD
{
    public class MaterialServiceBD : IMaterialService
    {
        private PiDbContext context;

        public MaterialServiceBD(PiDbContext context)
        {
            this.context = context;
        }

        public void CreateMaterial(MaterialBM model)
        {
            Material element = context.Materials.FirstOrDefault(rec => rec.SizeId == model.SizeId&& rec.TypeId == model.TypeId);
            if (element != null)
            {
                throw new Exception("Уже есть такой материал");
            }
            context.Materials.Add(new Material
            {
                Price=model.Price,
                SizeId=model.SizeId,
                TypeId=model.TypeId
            });
            context.SaveChanges();
        }

        public void DelMaterial(MaterialBM model)
        {
            throw new NotImplementedException();
        }

        public MaterialBM GetElement(int id)
        {
            Material element = context.Materials.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                Size size = context.Sizes.FirstOrDefault(recS => recS.Id == element.SizeId);
                Typemy type = context.Typemys.FirstOrDefault(recT => recT.Id == element.TypeId);
                return new MaterialBM
                {
                    Id = element.Id,
                    Price = element.Price,
                    SizeId = element.SizeId,
                    TypeId = element.TypeId,
                    Name = type.Name +"   "+ size.Name + ""
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<MaterialBM> GetList()
        {
            List<MaterialBM> result = context.Materials
               .Select(rec => new MaterialBM
               {
                   Id = rec.Id,
                   Price = rec.Price,
                   SizeId = rec.SizeId,
                   TypeId = rec.TypeId,
                   Name = context.Sizes.FirstOrDefault(recS => recS.Id == rec.SizeId).Name+ "  "+context.Typemys.FirstOrDefault(recT => recT.Id == rec.TypeId).Name+""
               })
               .ToList();
            return result;
        }

        public List<MaterialOnStockBM> GetListOnStock()
        {
            List<MaterialOnStockBM> matOnStock = new List<MaterialOnStockBM>();
            List<MaterialBM> materials = GetList();

            // List<MaterialBuyBM> materialBuys = GetListMaterialBuy();


            foreach (var mat in materials)
            {
                int buys = 0;
                List<MaterialBuyBM> materialBuys = context.MaterialBuys.Select(rec => new MaterialBuyBM
                {
                    Id = rec.Id,
                    Count = rec.Count
                }).Where(rec => rec.MaterialId == mat.Id)
                        .ToList();

                foreach (MaterialBuyBM materialBuy in materialBuys)
                {
                    buys += materialBuy.Count;
                }

                //выбрать такие заказы, где нужный статус 1,2,3  buys --;
                throw new NotImplementedException();

                matOnStock.Add(new MaterialOnStockBM
                {
                    Name = context.Sizes.FirstOrDefault(recS => recS.Id == mat.SizeId).Name + "  " + context.Typemys.FirstOrDefault(recT => recT.Id == mat.TypeId).Name + "",
                    Count = buys
                });

            }
            return matOnStock;
        }

        public List<MaterialBuyBM> GetListMaterialBuy()
        {

            List<MaterialBuyBM> result = context.MaterialBuys
               .Select(rec => new MaterialBuyBM
               {
                   Id = rec.Id,
                   Count = rec.Count,
                   MaterialId = rec.MaterialId
               })
               .ToList();
            return result;
        }


        public void UpdMaterial(MaterialBM model)
        {
            throw new NotImplementedException();
        }
    }
}
