namespace Task_Multiple_DB.Repositories
{
    public class DB2Repository : IDB2Repository
    {
        private readonly DbContext2 _context;

        public DB2Repository(DbContext2 context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Entity2>> GetAll()
        {
            return await _context.DB2Entities.ToListAsync();
        }

        public async Task<Entity2> GetById(int id)
        {
            return await _context.DB2Entities.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
