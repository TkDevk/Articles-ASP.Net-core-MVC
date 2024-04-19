using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Articles.Models;

namespace Articles.Data
{
    public class ArticlesContext : DbContext
    {
        public ArticlesContext (DbContextOptions<ArticlesContext> options)
            : base(options)
        {
        }

        public DbSet<Articles.Models.Article> Article { get; set; } = default!;
    }
}
