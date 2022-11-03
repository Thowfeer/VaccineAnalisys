using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineAnalysis.Core.Entites;

namespace VaccineAnalysis.Core
{
    public  class VaccineDbContext:DbContext
    {
        public VaccineDbContext(DbContextOptions<VaccineDbContext> options) :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<UserVaccineInfo> UserVaccineInfos { get; set; }
        public DbSet<VaccineType> VaccineTypes { get; set; }
    }
}
