namespace WebApplication1.Models
{
    public class LanguageDetails
    {
        public int Id { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
