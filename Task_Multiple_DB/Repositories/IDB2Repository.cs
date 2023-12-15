
namespace Task_Multiple_DB
{
    public interface IDB2Repository
    {
        Task<IEnumerable<Entity2>> GetAll();
        Task<Entity2> GetById(int id);
    }
}