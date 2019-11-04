using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.model;
using HRIS.service;

namespace HRIS.controller
{
    class StaffController
    {
        //the way to connet with the model.staff 
        public List<Staff> getDefaultStaffList()
        {
            //create a new list of staff
            StaffService abc = new StaffService();
            return abc.getDefaultStaffList();

        }
    }
}
