using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MediaCore;

namespace MediaCollectionCore.Entities
{
    public class MediaDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set;  }
    }
}
