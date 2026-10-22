using LINQ.DataSources;
using LINQ.Models;

namespace linq2.assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1

            //1.Get top 3 most expensive products

            //var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);




            //}
            #endregion

            #region question2
            ////2.show page 2 of products, with page size = 5
            //var resualt =Source.ProductList.Skip(5).Take(5);
            //foreach (var product in resualt)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion
        }
    }
}