using System.Data.Entity;
using VidlyApp.Models;

namespace VidlyApp.DbContext
{
    public class MyDbContext : System.Data.Entity.DbContext
    {
        public MyDbContext() : base("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wc_an\\Documents\\myDb.mdf;Integrated Security=True;Connect Timeout=30")
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}