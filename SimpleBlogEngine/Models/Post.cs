using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlogEngine.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public int UserID { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

    }
}
