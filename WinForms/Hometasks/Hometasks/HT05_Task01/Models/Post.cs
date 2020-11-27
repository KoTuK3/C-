using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_Task01.Models
{
    class Post
    {
        static public int PostId { get; private set; } = 1;
        public Post()
        {
            PostId += 1;
        }
        public string Header { get; set; }
        public string ImageSrc { get; set; }
        public string Description { get; set; }
        public int Likes { get; } = 0;
    }
}
