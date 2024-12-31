using Microsoft.EntityFrameworkCore;

namespace AfterClass12.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected MyDbContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server =LAPTOP-QKA6LG65; Initial Catalog = AfeterClass12Db; Integrated Security = true; TrustServerCertificate = True;");
        }
    }
}
