﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveManagement.DataModels;

namespace LeaveManagement.Repository.Interfaces
{
    public interface IHRRepository
    {
        void UpdateEmployeeProfile(ApplicationUser e);

    }
}
