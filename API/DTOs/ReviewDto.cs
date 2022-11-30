namespace API.DTOs
{
    public class ReviewDto
    {
        public string ReviewerName { get; set; } = "";

        public string Content { get; set; } = "";

        public DateTime CreatedAt { get; set; }
    }
}
