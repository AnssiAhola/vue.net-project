
namespace API.Entities
{
    public class Review
    {
        public int Id { get; set; }

        public string ReviewerName { get; set; } = "";

        public string ReviewerEmail { get; set; } = "";

        public string Content { get; set; } = "";

        public DateTime CreatedAt { get; set; }
    }

}
