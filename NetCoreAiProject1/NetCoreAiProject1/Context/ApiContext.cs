using Microsoft.EntityFrameworkCore;
using NetCoreAiProject1.Entities;

namespace NetCoreAiProject1.Context
{
    public class ApiContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ZOONPOLITIKION; initial catalog=ApiAIDb;" +
                "integrated security=true;trustservercertificate=true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
