using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL;

namespace ASL.Data
{
    public class ASLDBContext : DbContext
    {
        public ASLDBContext (DbContextOptions<ASLDBContext> options)
            : base(options)
        {
        }

        public DbSet<DAL.EmpProfile> EmpProfile { get; set; } = default!;

        public DbSet<DAL.DeptMaster> DeptMaster { get; set; } = default!;
    }
}
