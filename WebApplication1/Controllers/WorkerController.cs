using Microsoft.AspNetCore.Mvc;
using WebApplication1.BL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class WorkerController : Controller
    {
        private IWorkerService _weorkerService;

        public WorkerController(IWorkerService workerService)
        {
            this._weorkerService = workerService ?? throw new ArgumentNullException(nameof(workerService));
        }
      
        [HttpGet("GetWorkers")]
        public async Task<ActionResult<List<Worker>>> GetWorkersAsync()
        {
            return await _weorkerService.GetWorkersAsync();
        }
        /// <summary>
        //נמצאת בסרבר db אני מבצעת את הבדיקה בסרבר כדי שלא יוכל להכניחס לי נתונים שגויים ולשלוח וכן הגישה ל   
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        [HttpPost("GetWorkersByLanguage")]
        public async Task<List<Worker>> GetByLanguageAsync([FromBody] string language)
        {
            return await _weorkerService.GetByLanguageAsync(language);
        }
    }
}
