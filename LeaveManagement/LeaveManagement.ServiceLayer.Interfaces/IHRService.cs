using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveManagement.DataModels;
using LeaveManagement.ViewModels;

namespace LeaveManagement.ServiceLayer.Interfaces
{
    public interface IHRService
    {
        void RegisterEmployeeProfile(RegisterViewModel rvm);
        void UpdateEmployeeProfile(EmployeeInfoViewModel evm);

    }
}
