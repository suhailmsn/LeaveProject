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

namespace LeaveManagement.ServiceLayer
{
    public class PMService:IPMService
    {
        private readonly IPMRepository _PMRepository;

        public PMService(IPMRepository PMRepository)
        {
            _PMRepository = PMRepository;
        }
    }
}