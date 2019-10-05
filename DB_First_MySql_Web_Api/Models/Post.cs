using System;
using System.Collections.Generic;

namespace DB_First_MySql_Web_Api.Models
{
    public partial class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
