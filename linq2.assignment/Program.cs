using LINQ.DataSources;
using LINQ.Models;
using System.Collections;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

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
            #region question5
            //            5.Check if the ID list contains 9
            //   int[] ids = { 3, 9, 13, 18 };
            //var reuslt= ids.Contains(9);
            //Console.WriteLine(reuslt);

            #endregion
            #region question6
            ////            6.Group all products by Category and print each group with its
            ////product count.
            //var reuslt = Source.ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 0);
            //foreach (var group in reuslt)
            //{
            //    Console.WriteLine($"Category: {group.Key}, Count: {group.Count()}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}
            #endregion
            #region question7
            //            7.Group products by Category and project only product names per
            //group
            //var result = Source.ProductList.GroupBy(p => p.Category);
                                           
            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine(product.ProductName);
            //    }
            //}


                #endregion
        }
    }
}