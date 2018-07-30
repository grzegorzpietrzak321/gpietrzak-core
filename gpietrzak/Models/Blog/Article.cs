using System;
using System.Collections.Generic;

namespace gpietrzak.Models.Blog
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Text { get; set; }
        public DateTime PosteDateTime { get; set; }
        

        public virtual ICollection<ArticleTags> ArticleTagses { get; set; }
        public virtual ICollection<ArticleCategory> ArticleCategories { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
