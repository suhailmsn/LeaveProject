using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LeaveManagement.DataModels;
using LeaveManagement.Repository.Interfaces;

namespace LeaveManagement.Repositories
{
   
    public class HRRepository : IHRRepository
    {
        private LeaveManagementDbContext _db;
        public HRRepository(LeaveManagementDbContext db)
        {
            _db = new LeaveManagementDbContext();
        }

       
        public void UpdateEmployeeProfile(ApplicationUser e)
        {
            ApplicationUser ee;
            //ee = _db.EmployeeInfo.Where(temp => temp.EmployeeInfoID ==e.Id).FirstOrDefault();
            //if (ee != null)
            //{
           
            //    _db.SaveChanges();
            //}

        }
       
    }
}