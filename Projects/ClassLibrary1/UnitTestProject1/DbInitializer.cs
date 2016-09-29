using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTestProject1
{
   public class DbInitializer : DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            Customer customer = new Customer()
            {
                Name = "yasser",
                AdressLine1 = "Rue du pont,25",
                City = "Ottignies",
                Country = "Belgique",
                Email = "infos@me.com",
                Id = 3,
                Remark = "Ne pas avoir peur des chiens",
                PostCode = "6700"
            };
            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
