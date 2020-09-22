using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_Domazet.Models
{
    public class Kazeta:DbContext
    {
        public Kazeta(DbContextOptions<Kazeta>options):base(options)
        {
        }


        public DbSet<Video> Videos { get; set; }
    }
}
