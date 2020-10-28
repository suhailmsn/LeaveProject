using System;
using System.Collections.Generic;
using System.Linq;
using LeaveManagement.DataModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LeaveManagement.Repository.Interfaces;

namespace LeaveManagement.Repositories
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private LeaveManagementDbContext _db;
        public EmployeeRepository(LeaveManagementDbContext db)
        {
            _db = new LeaveManagementDbContext();
        }
        
        public void UpdateEmployeeInfo(EmployeeInfo e)
        {
            EmployeeInfo ei;
            ei = _db.EmployeeInfo.Where(temp => (temp.EmployeeInfoID == e.EmployeeInfoID)).FirstOrDefault();
            if(ei!=null)
            {
                ei.Hobbies = e.Hobbies;
                ei.ProjectsDone = e.ProjectsDone;
                ei.Bio = e.Bio;
                ei.Address = e.Address;
                ei.Contact = e.Contact;
                _db.SaveChanges();
            }
        }
        public void UpdateEmployeeEducation(EmployeeEducation e)
        {
            EmployeeEducation ee;
            ee = _db.EmployeeEducation.Where(temp => (temp.EmployeeEducationID == e.EmployeeEducationID)).FirstOrDefault();
            if (ee != null)
            {
                ee.Qualification = e.Qualification;
                ee.TenthGradeMark = e.TenthGradeMark;
                ee.TwelfthGradeMark = e.TwelfthGradeMark;
                ee.TwelfthSchoolName = e.TwelfthSchoolName;
                _db.SaveChanges();
            }
        }

        public EmployeeEducation ViewEmployeeEducation(int eid)
        {
            EmployeeEducation ee;
            ee = _db.EmployeeEducation.Where(temp => temp.EmployeeEducationID == eid).FirstOrDefault();
            return ee;
        }
        public EmployeeInfo ViewEmployeeInfo(int eid)
        {
            EmployeeInfo ei;
            ei = _db.EmployeeInfo.Where(temp => (temp.EmployeeInfoID == eid)).FirstOrDefault();
            return ei;
        }

    }
}