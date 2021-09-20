using DtAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtAPI.Data
{
    public class ApiDbContext:DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options):base(options)
        {

        }

        public DbSet<DtApi> DtApis { get; set; }
        public DbSet<Users> Users { get; set; }

    }
}
