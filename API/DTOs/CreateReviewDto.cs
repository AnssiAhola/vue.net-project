namespace API.DTOs
{
    public class CreateReviewDto
    {
        public string ReviewerName { get; set; } = "";

        public string ReviewerEmail { get; set; } = "";

        public string Content { get; set; } = "";
    }
}
