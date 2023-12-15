namespace Task_Multiple_DB.Repositories
{
    public class DB1Repository : IDB1Repository
    {
        private readonly DbContext1 _context;

        public DB1Repository(DbContext1 context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Entity1>> GetAll()
        {
            return await _context.DB1Entities.ToListAsync();
        }

        public async Task<Entity1> GetById(int id)
        {
            return await _context.DB1Entities.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
