using DapperNightProject.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DapperNightProject.Context
{
    public class MyContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=DbDapperNightNew;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }
        public DbSet<Record> Records { get; set; }

    }
}
