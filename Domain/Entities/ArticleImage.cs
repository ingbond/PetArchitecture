using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ArticleImage
    {
        public Guid Id { get; set; }
        public Guid ArticleId { get; set; }
        public string Bin { get; set; } = string.Empty;

        [ForeignKey("ArticleId")]
        public virtual Article? Article { get; set; }
    }
}
