using System.Collections.Generic;
using Microsoft.Data.Edm.Csdl;

namespace gpietrzak.Models.Blog
{
    public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ArticleTags> ArticleTagses { get; set; }
    }
}
