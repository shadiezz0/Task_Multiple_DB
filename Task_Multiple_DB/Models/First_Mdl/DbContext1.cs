

namespace Task_Multiple_DB.Models.First_Mdl
{
    public class DbContext1 : DbContext
    {
        public DbContext1(DbContextOptions<DbContext1> options) : base(options)
        {
        }
        public DbSet<Entity1> DB1Entities { get; set; }

    }
}
