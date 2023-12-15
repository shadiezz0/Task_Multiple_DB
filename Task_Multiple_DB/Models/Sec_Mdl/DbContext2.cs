namespace Task_Multiple_DB.Models.Sec_Mdl
{
    public class DbContext2 : DbContext
    {
        public DbContext2(DbContextOptions<DbContext2> options) : base(options)
        {
        }

        public DbSet<Entity2> DB2Entities { get; set; }

    }
}
