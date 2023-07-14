using Microsoft.EntityFrameworkCore;

namespace NetWithElasticsearch.Context
{
    public sealed class AppDbContext : DbContext
    {
        private readonly string _databaseConnection;
        public AppDbContext(string databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_databaseConnection);
        }

        public DbSet<Travel> Travels { get; set; }
    }

    public sealed class Travel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
