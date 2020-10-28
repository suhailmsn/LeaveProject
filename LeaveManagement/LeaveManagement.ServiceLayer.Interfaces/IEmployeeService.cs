using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveManagement.DataModels;
using LeaveManagement.ViewModels;

namespace LeaveManagement.ServiceLayer.Interfaces
{
    public interface IEmployeeService
    {

        void UpdateEmployeeInfo(EmployeeInfoViewModel evm);
        void UpdateEmployeeEducation(EmployeeInfoViewModel evm);
        EmployeeInfoViewModel ViewEmployeeEducation(int eid);
        EmployeeInfoViewModel ViewEmployeeInfo(int eid);
    }
}
