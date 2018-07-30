using System;

namespace gpietrzak.Models.Blog
{
    public class Comment
    {
        public int CommentId { get; set; }
        public DateTime PostedDateTime { get; set; }
        public string Content { get; set; }

        public Comment()
        {
            
        }

        public virtual Article Article { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}