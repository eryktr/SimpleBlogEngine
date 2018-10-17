using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlogEngine.Models
{
    public class PostAuthor
    {
        public int ID { get; set; }
        public int PostID { get; set; }
        public int UserID { get; set; }
    }
}
