using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeInitializer : DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            // Add some default data to the DeptMaster table
            context.DeptMasters.Add(new DeptMaster
            {
                DeptCode = 1,
                DeptName = "HR"
            });

            context.DeptMasters.Add(new DeptMaster
            {
                DeptCode = 2,
                DeptName = "Manager"
            });

            // Commit the changes to the database
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
