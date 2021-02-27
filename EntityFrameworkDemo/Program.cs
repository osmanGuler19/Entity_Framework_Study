using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ORM -> Object relational mapping
            //Nhibernate
            //Dapper

            GetAllPersonel();
            //GetProductsByCategory(1);


        }

        private static void GetAllPersonel()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var personel in northwindContext.Personels)
            {
                Console.WriteLine("{0} {1}  {2}",personel.Id,personel.Name,personel.Surname);
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p=>p.CategoryId == categoryId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
