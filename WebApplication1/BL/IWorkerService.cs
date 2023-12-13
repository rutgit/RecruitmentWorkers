using WebApplication1.Models;

namespace WebApplication1.BL
{
    public interface IWorkerService
    {
        public Task<List<Worker>> GetWorkersAsync();
        public Task<Worker> GetByWorkerIdAsync(int id);
        public Task<List<Worker>> GetByLanguageAsync(string language);
        public Task<Worker> GetByLastUpdateDateAsync(string type);
    }
}