using lab17.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    internal static class StoreStatistics
    {
        public static double GetStockPriceByManufacturer(int manufacturerId)
        {
            using var storeCtx = new StoreDBContext();
            var manufacturer = storeCtx.Manufacturers.FirstOrDefault(m => m.Id ==  manufacturerId);

            return storeCtx.Products.
                Where(p => p.Manufacturer == manufacturer).
                Sum(p => p.Label.Price * p.Stock);
        }

        // pt obt valorii stocului per categorie
        public static double GetStockPriceByCategory(int categoryId)
        {
            using var storeCtx = new StoreDBContext();
            var category = storeCtx.Categories.FirstOrDefault(c => c.Id == categoryId);

            return storeCtx.Products.
                Where(p => p.Category == category).
                Sum(p => p.Label.Price * p.Stock);
        }

        public static double GetTotalStockPrice()
        {
            using var storeCtx = new StoreDBContext();

            var manufacturersIds = storeCtx.Manufacturers.Select(m => m.Id).ToList();

            return manufacturersIds.Sum(m => GetStockPriceByManufacturer(m));
        }
        
        public static List<double> GetStockPriceForEachCategory()
        {
            using var storeCtx = new StoreDBContext();

            List<double> totalStocks = new List<double>();

            var categoriesIds = storeCtx.Categories.Select(c => c.Id).ToList();

            categoriesIds.ForEach(c => totalStocks.Add(GetStockPriceByCategory(c)));

            return totalStocks;
        }
        
    }
}
