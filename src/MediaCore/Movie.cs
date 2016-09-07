using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaCore
{
    public class Movie : IMediaItem
    {
        public DateTime Created { get; set; }

        [Key]
        public int Id { get; set; }
        public MediaType MediaCategory { get; set; } 
        public DateTime Modified { get; set; }
        public string Name { get; set; }
        
    }
}
