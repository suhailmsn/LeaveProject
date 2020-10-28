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
using LeaveManagement.Repository.Interfaces;
using LeaveManagement.ServiceLayer.Interfaces;

namespace LeaveManagement.ServiceLayer
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        
        public void UpdateEmployeeInfo(EmployeeInfoViewModel evm)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<EmployeeInfoViewModel,EmployeeInfo>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            EmployeeInfo e = mapper.Map<EmployeeInfoViewModel, EmployeeInfo>(evm);
            _employeeRepository.UpdateEmployeeInfo(e);
        }
        public void UpdateEmployeeEducation(EmployeeInfoViewModel evm)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<EmployeeInfoViewModel,EmployeeEducation>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            EmployeeEducation e = mapper.Map<EmployeeInfoViewModel,EmployeeEducation>(evm);
            _employeeRepository.UpdateEmployeeEducation(e);
        }

        public EmployeeInfoViewModel ViewEmployeeEducation(int eid)
        {
            EmployeeEducation e = _employeeRepository.ViewEmployeeEducation(eid);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<EmployeeEducation, EmployeeInfoViewModel>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            EmployeeInfoViewModel evm = mapper.Map<EmployeeEducation, EmployeeInfoViewModel>(e);
            return evm;
        }
        public EmployeeInfoViewModel ViewEmployeeInfo(int eid)
        {
            EmployeeInfo e = _employeeRepository.ViewEmployeeInfo(eid);
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<EmployeeInfo,EmployeeInfoViewModel>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            EmployeeInfoViewModel evm = mapper.Map<EmployeeInfo, EmployeeInfoViewModel>(e);
            return evm;
        }
    }    
}