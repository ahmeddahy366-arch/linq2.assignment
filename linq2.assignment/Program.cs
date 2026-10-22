using LINQ.DataSources;
using LINQ.Models;
using System.Collections;

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
            #region question3
            //3.Take products from the list as long as Their UnitPrice is less than
            //$25(list is ordered by price).

            //var  reusalt=Source.ProductList.OrderBy(p=>p.UnitPrice).TakeWhile(p=>p.UnitPrice<25);
            //foreach (var product in reusalt)
            //{
            //    Console.WriteLine(product);
            //}


            #endregion
            #region question4
            ////4.Check if ALL products in the "Seafood" category are in stock
            //var reuslt =Source.ProductList.Where(p=>p.Category=="Seafood").All(p=>p.UnitsInStock>0);
            //Console.WriteLine(reuslt);
            #endregion
        }
    }
}