using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataabaseFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindEntities db = new NorthwindEntities();
            // Join ve GroupBy da genellikle daha kolay anlaşılacağı için linq to sql kullanılıyor

            /*
                select ProductName,CategoryName
                from Categories
                inner join Products
                on Categories.CategoryID=Products.CategoryID
             */


            //var result = from c in db.Categories
            //             join p in db.Products
            //             on c.CategoryID equals p.CategoryID
            //             select new
            //             {
            //                 p.ProductName,
            //                 c.CategoryName
            //             };

            /*
                select ProductName,CategoryName,UnitPrice
                from Categories
                inner join Products
                on Categories.CategoryID=Products.CategoryID
                order by UnitPrice desc
             */

            //var result = from c in db.Categories
            //             join p in db.Products
            //             on c.CategoryID equals p.CategoryID
            //             orderby p.UnitPrice descending
            //             select new
            //             {
            //                 p.ProductName,
            //                 c.CategoryName,
            //                 p.UnitPrice
            //             };


            /*
                select CategoryID,COUNT(*) as NumberOfProducts
                from Products
                group by CategoryID 
             */

            //var result = from p in db.Products
            //             group p by p.CategoryID into g
            //             select new
            //             {
            //                 g.Key,
            //                 NumberOfProducts=g.Count()
            //             };


            /*
                select CategoryName,COUNT(*) as NumberOfProducts
                from Categories
                inner join Products
                on Categories.CategoryID=Products.CategoryID
                group by CategoryName
             */


            //var result = from c in db.Categories
            //             join p in db.Products
            //             on c.CategoryID equals p.CategoryID
            //             group c by c.CategoryName into g
            //             select new
            //             {
            //                 g.Key,
            //                 NumberOfProducts = g.Count()
            //             };

            /*
                select CategoryName,COUNT(*) as NumberOfProducts,
                Sum(UnitPrice) as TotalPrice,
                MAX(UnitPrice) as MaxPrice,
                MIN(UnitPrice) as MinPrice
                from Categories
                inner join Products
                on Categories.CategoryID=Products.CategoryID
                group by CategoryName             
             */

            //var result = from c in db.Categories
            //             join p in db.Products
            //             on c.CategoryID equals p.CategoryID
            //             group new { c, p } by new { c.CategoryName } into g
            //             select new
            //             {
            //                 // g.Key yada g.Key.CategoryName
            //                 g.Key.CategoryName,
            //                 NumberOfProducts = g.Count(),
            //                 TotalPrice=g.Sum(x=>x.p.UnitPrice),
            //                 MaxPrice = g.Max(x => x.p.UnitPrice),
            //                 MinPrice = g.Min(x => x.p.UnitPrice),
            //             };

            /*
                select CategoryName,COUNT(*) as NumberOfProducts,
                Sum(UnitPrice) as TotalPrice,
                MAX(UnitPrice) as MaxPrice,
                MIN(UnitPrice) as MinPrice
                from Categories
                inner join Products
                on Categories.CategoryID=Products.CategoryID
                group by CategoryName
                having Sum(UnitPrice) > 300
             */

            var result =(from c in db.Categories
                         join p in db.Products
                         on c.CategoryID equals p.CategoryID
                         group new { c, p } by new { c.CategoryName } into g
                         select new
                         {
                             // g.Key yada g.Key.CategoryName
                             g.Key.CategoryName,
                             NumberOfProducts = g.Count(),
                             TotalPrice = g.Sum(x => x.p.UnitPrice),
                             MaxPrice = g.Max(x => x.p.UnitPrice),
                             MinPrice = g.Min(x => x.p.UnitPrice),
                         }).Where(x=>x.TotalPrice>300);

            ConsoleTable.From(result).Write();
                                 
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
