using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LeaveManagement.DataModels;
using LeaveManagement.Repository.Interfaces;

namespace LeaveManagement.Repositories
{
 
    public class PMRepository:IPMRepository
    {
        private LeaveManagementDbContext _db;
        public PMRepository(LeaveManagementDbContext db)
        {
            _db = new LeaveManagementDbContext();
        }

    }
}