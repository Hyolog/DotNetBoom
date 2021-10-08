using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNetBoom.Models;

namespace DotNetBoom.Data
{
    public class DotNetBoomContext : DbContext
    {
        public DotNetBoomContext (DbContextOptions<DotNetBoomContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetBoom.Models.Company> Company { get; set; }
    }
}
