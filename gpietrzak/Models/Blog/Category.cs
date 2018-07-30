using System.Collections.Generic;

namespace gpietrzak.Models.Blog
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        public ICollection<ArticleCategory> ArticleCategories { get; set; }
    }
}
