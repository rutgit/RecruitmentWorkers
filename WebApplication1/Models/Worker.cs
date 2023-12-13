using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BeginYear { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public ICollection<Language> Languages { get; set; }
    }
}
