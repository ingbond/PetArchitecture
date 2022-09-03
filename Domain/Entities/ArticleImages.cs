using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class ArticleImages
    {
        public Guid Id { get; set; }
        public Guid ArticleId { get; set; }
        public string Bin { get; set; } = string.Empty;
    }
}
