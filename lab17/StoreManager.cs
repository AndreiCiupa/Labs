using lab17.Exceptions;
using lab17.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    internal static class StoreManager
    {
        public static void AddCategory(string name, string pathToPictogram)
        {
            using var storeCtx = new StoreDBContext();

            storeCtx.Add(new Category
            {
                Name = name,
                Pictogram = pathToPictogram
            });

            storeCtx.SaveChanges();
        }
        public static void AddManufacturer(string name, string address, string cui)
        {
            using var storeCtx = new StoreDBContext();

            storeCtx.Add(new Manufacturer
            {
                Name = name,
                Address = address,
                CUI = cui
            });

            storeCtx.SaveChanges();
        }
        public static void AddProduct(string name, int stock, int mnfctrId, 
            int ctgryId, Guid barcode, double price)
        {
            using var storeCtx = new StoreDBContext();

            if(!storeCtx.Manufacturers.Any(m => m.Id == mnfctrId))
            {
                throw new InvalidIdException($"Invalid manufacturer id {mnfctrId}");
            }

            if (!storeCtx.Categories.Any(c => c.Id == ctgryId))
            {
                throw new InvalidIdException($"Invalid caytegory id {ctgryId}");
            }

            var mnfctr = storeCtx.Manufacturers.FirstOrDefault(m => m.Id == mnfctrId);
            var ctgry = storeCtx.Categories.FirstOrDefault(c => c.Id == ctgryId);

            var newLabel = new Label
            {
                Barcode = barcode,
                Price = price,
                
            };

            var newProduct = new Product
            {
                Name = name,
                Stock = stock,
                Manufacturer = mnfctr,
                Category = ctgry,
                Label = newLabel
            };

            mnfctr.Products.Add(newProduct);
            ctgry.Products.Add(newProduct);

            storeCtx.SaveChanges();
        }
        public static void ChangeProductPrice(int productId, double newPrice)
        {
            using var storeCtx = new StoreDBContext();

            var label = storeCtx.Labels.FirstOrDefault(p => p.Id == productId);

            if (label == null)
            {
                throw new InvalidIdException($"Invalid product id {productId}"); 
            }

            label.Price = newPrice;

            storeCtx.SaveChanges();
        }
        public static void DeleteProduct(int productId)
        {
            using var storeCtx = new StoreDBContext();

            var product = storeCtx.Products.FirstOrDefault(p => p.Id == productId);
            if(product == null) { return; }

            storeCtx.Remove(product);
            storeCtx.SaveChanges();
        }
        public static void DeleteManufacturer(int manufacturerId)
        {
            using var storeCtx = new StoreDBContext();

            var manufacturer = storeCtx.Manufacturers.FirstOrDefault(m => m.Id == manufacturerId);
            if (manufacturer == null) { return; }

            storeCtx.Remove(manufacturer);
            storeCtx.SaveChanges();

        }
        public static void DeleteCategory(int categoryId)
        {
            using var storeCtx = new StoreDBContext();

            var category = storeCtx.Categories.FirstOrDefault(c => c.Id == categoryId);
            if (category == null) { return; }

            storeCtx.Remove(category);
            storeCtx.SaveChanges();
        }
        public static void DeleteLabel(int labelId)
        {
            using var storeCtx = new StoreDBContext();

            var label = storeCtx.Labels.FirstOrDefault(l => l.Id == labelId);
            if (label == null) { return; }

            storeCtx.Remove(label);
            storeCtx.SaveChanges();
        }
    }
}
