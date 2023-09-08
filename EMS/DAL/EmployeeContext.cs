using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("ASLDBContext")
        {
            Database.SetInitializer(new EmployeeInitializer());
        }
        public DbSet<DeptMaster> DeptMasters { get; set; }
        public DbSet<EmpProfile> EmpProfiles { get; set; }
    }
}
