using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCollection
{
    public class Movie : IMediaItem
    {
        public DateTime Created { get; set; }
        public MediaType MediaCategory { get; set; } 
        public DateTime Modified { get; set; }
        public string Name { get; set; }
        
    }
}
