using Microsoft.Office.Interop.Word;
using PI_Models;
using PI_Service.BindingModels;
using PI_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
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
               

                matOnStock.Add(new MaterialOnStockBM
                {
                    Id = mat.Id,
                    Name = context.Sizes.FirstOrDefault(recS => recS.Id == mat.SizeId).Name + "  " + context.Typemys.FirstOrDefault(recT => recT.Id == mat.TypeId).Name + "",
                    Count = CountOst(mat.Id)
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

        public int CountOst(int materialId)
        {

            int ost = 0; //контрольное значение

            //считаем покупки
            List<MaterialBuyBM> materialBuys = context.MaterialBuys.Select(rec => new MaterialBuyBM
            {
                Id = rec.Id,
                MaterialId = rec.MaterialId,
                Count = rec.Count
            }).Where(rec => rec.MaterialId == materialId).ToList();


            foreach (var materialBuy in materialBuys)
            {
                ost += materialBuy.Count;
            }


            //считаем расходы
            List<MaterialOrderBM> materialOrders = context.MaterialOrders.Select(rec => new MaterialOrderBM
            {
                Id = rec.Id,
                MaterialId = rec.MaterialId,
                OrderId = rec.OrderId
            }).Where(rec => rec.MaterialId == materialId).ToList();

            foreach (var materialOrder in materialOrders)
            {
                Order order = context.Orders.FirstOrDefault(rec => rec.Id == materialOrder.OrderId);
                if (order.Status != 0)
                {
                    ost--;
                }
            }


            return ost;
        }

        public List<MaterialBM> GetListSize(int id)
        {
            List<MaterialBM> result = context.Materials
               .Select(rec => new MaterialBM
               {
                   Id = rec.Id,
                   Price = rec.Price,
                   SizeId = rec.SizeId,
                   TypeId = rec.TypeId,
                   Name = context.Sizes.FirstOrDefault(recS => recS.Id == rec.SizeId).Name + "  " + context.Typemys.FirstOrDefault(recT => recT.Id == rec.TypeId).Name + ""
               }).Where(rec =>rec.SizeId==id)
               .ToList();
            return result;
        }

        public bool ListShop(string fileName)
        {
            List<MaterialBM> materials = GetList();
            List<MaterialOnStockBM> matOnStock = new List<MaterialOnStockBM>();
           
            foreach (var mat in materials)
            {
                int need = 0;
                List<MaterialOrderBM> materialOrders = context.MaterialOrders.Select(rec => new MaterialOrderBM
                {
                    Id = rec.Id,
                    MaterialId = rec.MaterialId,
                    OrderId = rec.OrderId
                }).Where(rec => rec.MaterialId == mat.Id).ToList();

                foreach (var materialOrder in materialOrders)
                {
                    Order order = context.Orders.FirstOrDefault(rec => rec.Id == materialOrder.OrderId);
                    if (order.Status == 0)
                    {
                        need++;
                    }
                }
                if (need - CountOst(mat.Id) > 0)
                {
                    matOnStock.Add(new MaterialOnStockBM
                    {
                        Id = mat.Id,
                        Name = context.Sizes.FirstOrDefault(recS => recS.Id == mat.SizeId).Name + "  " + context.Typemys.FirstOrDefault(recT => recT.Id == mat.TypeId).Name + "",
                        CountNeed = need - CountOst(mat.Id)
                    });
                }
            }




            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            var winword = new Microsoft.Office.Interop.Word.Application();
            try
            {
                object missing = System.Reflection.Missing.Value;
                //создаем документ
                Microsoft.Office.Interop.Word.Document document =
                    winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                //получаем ссылку на параграф
                var paragraph = document.Paragraphs.Add(missing);
                var range = paragraph.Range;
                //задаем текстВ
                range.Text = "Список покупок";

                //задаем настройки шрифта
                var font = range.Font;
                font.Size = 16;
                font.Name = "Times New Roman";
                font.Bold = 1;
                //задаем настройки абзаца
                var paragraphFormat = range.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 0;
                //добавляем абзац в документ
                range.InsertParagraphAfter();

                var paragraph12 = document.Paragraphs.Add(missing);
                var range12 = paragraph12.Range;
                //задаем текстВ
                range12.Text = "Печать от даты " + (DateTime.Now.Date).ToString("yyyy.MM.dd");

                //задаем настройки шрифта
                var font12 = range12.Font;
                font12.Size = 16;
                font12.Name = "Times New Roman";
                font12.Bold = 1;
                //задаем настройки абзаца
                var paragraphFormat12 = range12.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 0;
                //добавляем абзац в документ
                range12.InsertParagraphAfter();


              
                //создаем таблицу

              



                var paragraphTable = document.Paragraphs.Add(Type.Missing);
                var rangeTable = paragraphTable.Range;
                var table = document.Tables.Add(rangeTable, matOnStock.Count + 1, 3, ref missing, ref missing);

                font = table.Range.Font;
                font.Size = 14;
                font.Name = "Times New Roman";

                var paragraphTableFormat = table.Range.ParagraphFormat;
                paragraphTableFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphTableFormat.SpaceAfter = 0;
                paragraphTableFormat.SpaceBefore = 0;


                table.Cell(1, 1).Range.Text = "Номер";
                table.Cell(1, 2).Range.Text = "Материал";
                table.Cell(1, 3).Range.Text = "Кол-во";
                //table.Cell(1, 4).Range.Text = "Сумма";

                for (int i = 0; i < matOnStock.Count; ++i)
                {
                    table.Cell(i + 2, 1).Range.Text = (matOnStock[i].Id).ToString();
                    table.Cell(i + 2, 2).Range.Text = matOnStock[i].Name;
                    table.Cell(i + 2, 3).Range.Text = (matOnStock[i].CountNeed).ToString();
                }
                //задаем границы таблицы
                table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleInset;
                table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

              
                //сохраняем
                object fileFormat = WdSaveFormat.wdFormatXMLDocument;
                document.SaveAs(fileName, ref fileFormat, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing);
                document.Close(ref missing, ref missing, ref missing);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;

            }
            finally
            {
                winword.Quit();
            }

        }
    }
}
