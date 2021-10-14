using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concreate
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [StringLength(150)]

        public string CommentUsername { get; set; }
        [StringLength(150)]

        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
