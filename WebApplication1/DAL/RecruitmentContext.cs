using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class RecruitmentContext:DbContext
    {
        public RecruitmentContext(DbContextOptions<RecruitmentContext> options):base(options)
        {           
        }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LanguageDetails> LanguagesDetails { get; set; }
    }
}
