using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LeaveManagement.DataModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LeaveManagement.Repositories
{
    public class LeaveManagementDbContext : IdentityDbContext<ApplicationUser>
    {
        public LeaveManagementDbContext(): base("LeaveManagementDbConnectionString")
        {
        }
        public static LeaveManagementDbContext Create()
        {
            return new LeaveManagementDbContext();
        }

        public DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducation { get; set; }
    }
}
