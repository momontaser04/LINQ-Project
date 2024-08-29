

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using static LProject.ListGenerators;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace LProject

{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Restriction Operators
            //1. Find all products that are out of stock.


            //var Allproduct = ProductList.Where(p => p.UnitsInStock==0 );
            //foreach (var product in Allproduct)
            //{
            //    Console.WriteLine(product);
            //}

            //2. Find all products that are in stock and cost more than 3.00 per unit.


            //var Mthree = ProductList.Where(p => p.UnitsInStock > 3);
            //foreach (var product in Mthree)
            //{
            //    Console.WriteLine(product);
            //}

            //3. Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //    .Select((name, index) => new { Name = name, Index = index })
            //    .Where(x => x.Name.Length < x.Index)
            //    .Select(x => x.Name);

            //foreach(var x in result)
            //{

            //    Console.WriteLine(x);
            //}


            #endregion

            #region 2-Element Operators

            //1.Get first Product out of Stock
            //var First = ProductList.FirstOrDefault();
            //Console.WriteLine(First);


            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var fproduct = ProductList.FirstOrDefault(p => p.UnitsInStock > 1000);
            //Console.WriteLine(fproduct?.ProductName ?? "null");


            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Retrieve the second number greater than 5
            //int secondnafive = Arr
            //     .Where(n => n > 5) // Filter numbers greater than 5
            //.ElementAt(1);
            //Console.WriteLine(secondnafive);

            //other solution

            //  int secondnafive = Arr
            //.Where(n => n > 5) 
            //.Skip(1).FirstOrDefault();
            //  Console.WriteLine(secondnafive);


            #endregion

            #region 3-Set Operators


            //1. Find the unique Category names from Product List

            //var Uniqecategory = ProductList.Select(p => p.Category).Distinct();
            //foreach (var i in Uniqecategory)
            //{
            //    Console.WriteLine(i);
            //}

            //2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var lst = ProductList.Select(x => x.ProductName[0]).Concat(ProductList.Select(C => C.Category[0])).Distinct()
            //    ;
            //foreach (var x in lst)
            //{
            //    Console.WriteLine(x);
            //}

            //3. Create one sequence that contains the common first letter from both product and customer names

            //var commonletter=ProductList.Select(x => x.ProductName[0]).Union(CustomerList.Select(p => p.CompanyName[0])).Distinct();
            //foreach (var item in commonletter)
            //{
            //    Console.WriteLine(item);
            //}



            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var first = ProductList.Select(p => p.ProductName[0]);
            //var second = CustomerList.Select(x => x.CompanyName[0]);
            //var result = first.Except(second).OrderBy(x => x);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //5.Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates

            //var c = ProductList.Count();
            //var first = ProductList.Select(p => p.ProductName[p.ProductName.Length - 3]).Concat(CustomerList.Select(p => p.CompanyName[p.CompanyName.Length - 3]));
            //var second = ProductList.Select(p => p.ProductName[p.ProductName.Length - 2]).Concat(CustomerList.Select(p => p.CompanyName[p.CompanyName.Length - 2]));
            //var third = ProductList.Select(p => p.ProductName[p.ProductName.Length-1 ]).Concat(CustomerList.Select(p => p.CompanyName[p.CompanyName.Length-1 ]));

            //var final = first.Concat(second).Concat(third);
            //foreach(var item in final)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4-Aggregate Operators
            //1. Uses Count to get the number of odd numbers in the array
            //int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr1.Where(n => n % 2 != 0).Count();
            //Console.WriteLine(result);

            //. 2Return a list of customers and how many orders each has.

            //var lst = from e in CustomerList
            //select new {cust = e, custo = e.Orders.Count()};
            //foreach (var e in lst)
            //{
            //   Console.WriteLine(e.custo);
            //    Console.WriteLine(e.cust);
            //}

            //
            //   3.Return a list of categories and how many products each has

            //var last = from e in ProductList
            //          group e by e.Category
            //          into g
            //          select new { name = g.Key, cnt = g.Count() };

            //foreach (var e in last)
            //{
            //    Console.WriteLine(e.name);
            //    Console.WriteLine(e.cnt);


            //4 Get the total of the numbers in an array.
            //int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result=Arr2.Sum(x => x);
            //Console.WriteLine(result);

            //5. Get the total units in stock for each product category.

            //var result = ProductList.GroupBy(p => p.Category).Select(g => new                  
            //{
            //    Category = g.Key,               
            //    TotalUnitsInStock = g.Sum(p => p.UnitsInStock) 
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category}      {item.TotalUnitsInStock}");

            //}
            //6.. Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    categ = g.Key,

            //    price = g.Min(propa => propa.UnitsInStock)

            //})
            //;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.categ}   {item.price}");
            //}

            //7. Get the most expensive price among each category's products



            //var result = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    categ = g.Key,

            //    price = g.Max(propa => propa.UnitsInStock)

            //})
            //;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.categ}   {item.price}");
            //}



            //8Get the products with the most expensive price in each category.

            //var result = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    categ = g.Key,

            //    price = g.Max(propa => propa.UnitsInStock)

            //})
            //;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.categ}   {item.price}");
            //}

            #endregion


            #region 5- Ordering Operators
            //1. Sort a list of products by name
            //var result = ProductList.OrderBy(p => p.ProductName);
            //foreach ( var p in result )
            //{
            //    Console.WriteLine(p);
            //}


            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr3.OrderBy(x => x);
            //foreach ( var x in result )
            //{
            //    Console.WriteLine(x);
            //}

            //3. Sort a list of products by units in stock from highest to lowest.
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}

            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr4 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr4.OrderBy(b => b.Length).ThenBy(b => b);
            //foreach ( var b in result)
            //{
            //    Console.WriteLine(b);
            //}

            //5.Sort first by word length and then by a case -insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result =words.OrderBy(b=>b.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}

            // 6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductList.OrderByDescending(p => p.Category).ThenByDescending(a => a.UnitPrice);
            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}

            //7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr5 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result=Arr5.OrderByDescending(p=>p.Length).ThenByDescending(p=>p,StringComparer.OrdinalIgnoreCase);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            // 8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array
            //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = arr
            //    .Where(word => word.Length > 1 && word[1] == 'i') 
            //    .Reverse(); 


            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}


            #endregion


            #region 6- Partitioning Operators
            //1. Get the first 3 orders from customers in Washington
            //var result = CustomerList.Where(p => p.City == "Washington").SelectMany(c => c.Orders).Take(3);
            //foreach (var o in result)
            //{
            //    Console.WriteLine(o);
            //}


            //2-2. Get all but the first 2 orders from customers in Washington.
            //var result = CustomerList.Where(p => p.City == "Washington").SelectMany(c => c.Orders).Skip(3);
            //foreach (var o in result)
            //{
            //    Console.WriteLine(o);
            //}


            //3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Select((n, i) => new { n, i }).TakeWhile(m => m.n > m.i).Select(p => p.n);
            //foreach ( var n in result)
            //{
            //    Console.WriteLine(n);
            //}

            //4. Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Where(p => p % 3 != 0);
            //foreach ( var i in result )
            //{
            //    Console.WriteLine(i);
            //}

            //5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.Select((value, index) => new { value, index }).Where(p => p.value < p.index);
            //foreach(var i in result)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion


            #region 7- Projection Operators

            //1. Return a sequence of just the names of a list of products.
            //var result =ProductList.Select(x=>x.ProductName).ToList();
            //foreach(var  item in result) {

            //    Console.WriteLine(item);
            //}

            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).




            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //// LINQ query to produce a sequence of uppercase and lowercase versions of each word
            //var result = words
            //    .Select(word => new
            //    {
            //        Original = word,
            //        Uppercase = word.ToUpper(),
            //        Lowercase = word.ToLower()
            //    });


            //Console.WriteLine("Original, Uppercase, and Lowercase versions of each word:");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Original: {item.Original}, Uppercase: {item.Uppercase}, Lowercase: {item.Lowercase}");
            //}




            //3 4. Determine if the value of ints in an array match their position in the array.
            //int[] Arr6 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var re = Arr6.Select((value, index) => new { value, index }).Select(p => p.value.Equals(p.index));

            //foreach (var i in re)
            //{
            //    Console.WriteLine(i);


            //}

            //5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB   
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };


            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { a, b };


            //Console.WriteLine("Pairs where a < b:");
            //foreach (var pair in result)
            //{
            //    Console.WriteLine($"{pair.a} is less than {pair.b}");
            //}


            //6. Select all orders where the order total is less than 500.00.
            // var ordersUnder500 = CustomerList
            //.SelectMany(customer => customer.Orders) 
            //.Where(order => order.Total < 500.00M);

            // foreach ( var order in ordersUnder500 )
            // {
            //     Console.WriteLine(order.ToString());
            // }


            //7. Select all orders where the order was made in 1998 or later.

            //var result = CustomerList.SelectMany(x => x.Orders).Where(p => p.OrderDate.Year >= 1998);

            //foreach (var i in result)
            //{

            //    Console.WriteLine(i);
            //}


            #endregion
            #region 8- Quantifiers

            //1. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //    var groupedProducts = ProductList
            //.Where(product => product.UnitsInStock == 0) 
            //.GroupBy(product => product.Category) 
            //.Select(group => new
            //{
            //    Category = group.Key,
            //    Products = group.ToList()
            //});

            //    Console.WriteLine("Categories with at least one product out of stock:");
            //    foreach (var categoryGroup in groupedProducts)
            //    {
            //        Console.WriteLine($"Category: {categoryGroup.Category}");
            //        foreach (var product in categoryGroup.Products)
            //        {
            //            Console.WriteLine($"  ProductID: {product.ProductID}, ProductName: {product.ProductName}, UnitsInStock: {product.UnitsInStock}");
            //        }
            //    }

            //3. Return a grouped a list of products only for categories that have all of their products in stock.

            //        var groupedProducts = ProductList
            //.GroupBy(product => product.Category) 
            //.Where(group => group.All(product => product.UnitsInStock > 0)) 
            //.Select(group => new
            //{
            //    Category = group.Key,
            //    Products = group.ToList() 
            //});


            //        Console.WriteLine("Categories with all products in stock:");
            //        foreach (var categoryGroup in groupedProducts)
            //        {
            //            Console.WriteLine($"Category: {categoryGroup.Category}");
            //            foreach (var product in categoryGroup.Products)
            //            {
            //                Console.WriteLine($"  ProductID: {product.ProductID}, ProductName: {product.ProductName}, UnitsInStock: {product.UnitsInStock}");
            //            }
            //        }

            //1. Use group by to partition a list of numbers by their remainder when divided by 5
            //int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };


            //var groupedByRemainder = numbers
            //    .GroupBy(number => number % 5);

            
            //foreach (var group in groupedByRemainder)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
              #endregion
            }
    }
}
