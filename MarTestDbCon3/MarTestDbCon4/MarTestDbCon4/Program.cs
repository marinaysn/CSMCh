using System;

namespace MarTestDbCon4
{
    class Program
    {
        public static object Customers { get; private set; }

        static void Main(string[] args)
        {

            var query =
                from c in Customers
                where c.Country == "Italy"
                orderby c.ContactName
                select new { c.ContactName, c.City };

            foreach (var cust in query)
            {
                Console.WriteLine("{0} -  {1}", cust.ContactName, cust.City);
            }


            Console.WriteLine("Hello World!");
        }
    }
}
