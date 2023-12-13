using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebApplication1.Models;
using static Azure.Core.HttpHeader;

namespace WebApplication1.DAL
{
    public class WorkerDAL : IWorkerDAL

    {
        private readonly RecruitmentContext _recruitmentContext;

        public WorkerDAL(RecruitmentContext recruitmentContext)
        {
            this._recruitmentContext = recruitmentContext ?? throw new ArgumentNullException(nameof(recruitmentContext));
        }

        public async Task<List<Worker>> GetByLanguageAsync(string language)
        {
            //return await _recruitmentContext.Workers
            //            .Where(l => l.Name == language).Select(;

            //return await _recruitmentContext.Languages
            //           .Where(l => l.Name == language)
            //           .Select(w => w.Id).ToListAsync();

            /////////foreachאז ניסיתי ב linqהסתבכתי לכתוב את ה  
            ///יש לי מה להמשיך פה...זה לא גמור

            try { 
            List<Worker> workersl = new List<Worker>();

            List<Worker> workers = await _recruitmentContext.Workers.ToListAsync();

            foreach (Worker p in workers)
            {
                foreach (Language l in p.Languages)
                {
                    if (l.Name == language)
                        workersl.Add(p);
                }
            }

            return workersl;

            }catch(Exception ex)
            {
                throw new Exception("can't get " + ex);
            }
        }

        public Task<Worker> GetByLastUpdateDateAsync(string date)
        {
            throw new NotImplementedException();
        }

        public Task<Worker> GetByWorkerIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Worker>> GetWorkersAsync()
        {
            try { 
            return await _recruitmentContext.Workers.Include(w=>w.Languages).ToListAsync();
            }   catch(Exception ex)
            {
                throw new Exception("can't get users" + ex);
            }
        }
    }
}
