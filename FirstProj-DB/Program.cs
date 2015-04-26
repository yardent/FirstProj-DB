using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace FirstProj_DB
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new ConGeoR())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var busName = Console.ReadLine();

                var blog = new Business { name = busName };
                db.businesses.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.businesses
                            orderby b.name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
