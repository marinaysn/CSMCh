using System;
using System.Collections.Generic;
//using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.SqlClient;


using Microsoft.Data.SqlClient;
using System.Data.SqlServerCe;


namespace marCh1
{
    public class Listing1_2ProLinq
    {

        public static string GetMiddle(string str)
        {

            XElement books = XElement.Parse(
            @"<books>
            <book>
            <title>Pro LINQ: Language Integrated Query in C# 2010</title>
            <author>Joe Rattz</author>
            </book>
            <book>
            <title>Pro .NET 4.0 Parallel Programming in C#</title>
            <author>Adam Freeman</author>
            </book>
            <book>
            <title>Pro VB 2010 and the .NET 4.0 Platform</title>
            <author>Andrew Troelsen</author>
            </book>
            </books>");
            var titles = from book in books.Elements("book")
                         where (string)book.Element("author") == "Joe Rattz"
                         select book.Element("title");

            //foreach (var title in titles)
            //    Console.WriteLine(title.Value);


            string connetionString;
            connetionString = @"Data Source=BLMarina5760\SQL2019;Initial Catalog=Northwind; Integrated Security=True";


            string queryString =
            "SELECT top 10 * FROM dbo.Customers;";
            //using (SqlConnection connection = new SqlConnection( connetionString))
            //{
            //    SqlCommand command = new SqlCommand(
            //        queryString, connection);
            //    connection.Open();
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            Console.WriteLine(String.Format("{0}, {1}",
            //                reader[0], reader[1]));

            //        }
            //    }

            //    connection.Close();
            //}

            SqlConnection connection = new SqlConnection(connetionString);
            SqlCommand command = new SqlCommand( queryString, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            connection.Close();

            return "Connected";

            

            return "";
        }
    }

    


}



