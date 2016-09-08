using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MediaCore
{
    public class Music : IMediaItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public MediaType[] MediaType { get; set; }

        public Genre[] Genre { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public DateTime Modified { get; set; }
    }
}
