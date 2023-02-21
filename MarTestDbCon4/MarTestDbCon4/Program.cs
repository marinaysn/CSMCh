using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data;

namespace MarTestDbCon4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer[] Customers1;
            
            DataSet ds = new DataSet();
            DataTable Customers = ds.Tables["Customer"];

            DataContext db = new DataContext(@"Data Source=BLMarina5760\SQL2019;Initial Catalog=Northwind;Trusted_Connection=True");
            Table<Customer> Customer = db.GetTable<Customer>();


            var query =
            from c in Customer
            where c.Country == "Italy"
            orderby c.ContactName
            select new { c.ContactName, c.City };

            foreach (var cust in query)
            {
                Console.WriteLine("{0} -  {1}", cust.ContactName, cust.City);
            }

            Console.ReadLine();

        }
    }
}
