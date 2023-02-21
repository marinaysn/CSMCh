using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarTestDbCon5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NorthwindDataClassesDataContext dc = new NorthwindDataClassesDataContext();

            //var customers =
            //    from c in dc.Customers
            //select c;

            //foreach (var cust in customers)
            //{
            //    Console.WriteLine("{0} -  {1}", cust.ContactName, cust.City);
            //}

            //Console.WriteLine("==========================================");

            //var products =
            //    from p in dc.Alphabetical_list_of_products
            //    select p;

            //foreach (var prod in products)
            //{
            //    Console.WriteLine("{0} -  {1}", prod.ProductName, prod.UnitPrice);
            //}

            var query =
                from c in dc.Customers
                where c.Country == "Italy"
                orderby c.ContactName
                select new { c.ContactName, c.City };

            foreach (var cust in query)
            {
                Console.WriteLine("{0} -  {1}", cust.ContactName, cust.City);
            }


            Console.Read();

        }
    }
}
