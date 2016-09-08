using System;
using System.ComponentModel.DataAnnotations;

namespace MediaCore
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
