using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.BL
{
    public class WorkerService : IWorkerService
    {
        private readonly IWorkerDAL _workerDAL;

        public WorkerService(IWorkerDAL workerDAL)
        {
            this._workerDAL = workerDAL ?? throw new ArgumentNullException(nameof(workerDAL));
        }

        public async Task<List<Worker>> GetByLanguageAsync(string language)
        {
            return await _workerDAL.GetByLanguageAsync(language);
        }

        public Task<Worker> GetByLastUpdateDateAsync(string type)
        {
            throw new NotImplementedException();
        }

        public Task<Worker> GetByWorkerIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Worker>> GetWorkersAsync()
        {
            return await _workerDAL.GetWorkersAsync();
        }
    }
}
