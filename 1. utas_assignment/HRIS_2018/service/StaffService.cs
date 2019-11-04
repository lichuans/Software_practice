using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.database;
using HRIS.model;


namespace HRIS.service
{
    class StaffService
    {
        public List<Staff> getDefaultStaffList()
        {
            StaffDAO ll = new StaffDAO();

            return ll.getDefaultStaffList();
        }
    }
}
