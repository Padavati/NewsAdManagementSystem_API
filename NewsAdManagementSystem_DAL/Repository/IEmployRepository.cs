﻿using NewsAdManagementSystem_Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsAdManagementSystem_DAL.Repository
{
    public interface IEmployRepository
    {
        void AddEmploy(EmployDetails employDetails);
        void UpdateEmploy(EmployDetails employDetails);
        void DeleteEmploy(int EmpID);
         EmployDetails GetEmployDetailsByID(int EmpID);
         IEnumerable<EmployDetails> GetEmployDetails();
        void RemoveEmploy(int empID);
        void GetEmployDetailsById(int empID);
    }
}