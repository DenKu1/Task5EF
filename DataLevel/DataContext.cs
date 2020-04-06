using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }

        public DataContext() : base("DBConnection")
        {
        }

        static DataContext()
        {
            Database.SetInitializer(new DBInitializer());
        }
    }

    public class DBInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var c1 = new Category { Name = "Meat" };
            var c2 = new Category { Name = "Milk" };
            var c3 = new Category { Name = "Vegetables" };
            var c4 = new Category { Name = "Fruits" };
            var c5 = new Category { Name = "Health" };

            var p1 = new Provider { Name = "MeatCompany" };
            var p2 = new Provider { Name = "Tulchinka" };
            var p3 = new Provider { Name = "UrugvaiFruits" };
            var p4 = new Provider { Name = "FirstPekarna" };
            var p5 = new Provider { Name = "OOOHealthCare" };

            Product[] products =
            {
                new Product {Name = "Chiken", Provider = p1, Category = c1, Price = 20m},
                new Product {Name = "Milkpackage", Provider = p2, Category = c2, Price = 30m},
                new Product {Name = "Cheese", Provider = p2, Category = c2, Price = 40m},
                new Product {Name = "Oranges", Provider = p3, Category = c4, Price = 43m},
                new Product {Name = "Bananas", Provider = p3, Category = c4, Price = 42m},
                new Product {Name = "Soap", Provider = p5, Category = c5, Price = 60m}              
            };

            context.Products.AddRange(products);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
