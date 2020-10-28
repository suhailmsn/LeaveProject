using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using LeaveManagement.ViewModels;
using LeaveManagement.DataModels;
using LeaveManagement.Repositories;
using LeaveManagement.ServiceLayer;
using LeaveManagement.ServiceLayer.Interfaces;
using LeaveManagement.Repository.Interfaces;
using Microsoft.AspNet.Identity;

namespace LeaveManagement.ServiceLayer
{
    public class HRService:IHRService
    {   
        private readonly IHRRepository _hrRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

       
        public HRService(IHRRepository hrRepository, IEmployeeRepository employeeRepository, ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            _hrRepository = hrRepository;
            _employeeRepository = employeeRepository;
            _userManager = userManager;
            _signInManager = signInManager;
        }


            public void RegisterEmployeeProfile(RegisterViewModel rvm)
        {
            var user = new ApplicationUser {  Email = rvm.Email,PasswordHash=rvm.Password,PhoneNumber=rvm.Contact };
            var result =_userManager.CreateAsync(user, rvm.Password);

            //var config = new MapperConfiguration(cfg => { cfg.CreateMap<NewEmployeeViewModel,ApplicationUser>(); cfg.IgnoreUnmapped(); });
            //IMapper mapper = config.CreateMapper();
            //ApplicationUser l = mapper.Map<NewEmployeeViewModel,ApplicationUser>(evm);           
            //_hrRepository.CreateEmployeeProfile(l);
        }
        public void UpdateEmployeeProfile(EmployeeInfoViewModel evm)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<EmployeeInfoViewModel, ApplicationUser>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            ApplicationUser e = mapper.Map<EmployeeInfoViewModel, ApplicationUser>(evm);
            _hrRepository.UpdateEmployeeProfile(e);
        }
    

    }
}