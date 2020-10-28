using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeaveManagement.DataModels;
using LeaveManagement.ServiceLayer;
using LeaveManagement.ServiceLayer.Interfaces;
using LeaveManagement.ViewModels;

namespace LeaveManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IHRService _hrService;
        private readonly IEmployeeService _employeeService;
      
        public EmployeeController(IHRService hrService,IEmployeeService employeeService)
        {
            _hrService = hrService;
            _employeeService = employeeService;

        }
        public ActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel rvm)
        {
            _hrService.RegisterEmployeeProfile(rvm);
            return View();
        }
        public ActionResult EditInfo()
        {
            int id = 1;
            EmployeeInfoViewModel infoViewModel = _employeeService.ViewEmployeeInfo(id);
            return View(infoViewModel);
        }
        [HttpPost]
        public ActionResult EditInfo(EmployeeInfoViewModel evm)
        {
            _employeeService.UpdateEmployeeInfo(evm);
            return View();
        }

    }
}