
namespace Task_Multiple_DB
{
    public interface IDB1Repository
    {
        Task<IEnumerable<Entity1>> GetAll();
        Task<Entity1> GetById(int id);
    }
}