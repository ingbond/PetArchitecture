namespace Domain.Entities
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
