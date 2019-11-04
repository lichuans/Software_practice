using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.controller;
using HRIS.model;

namespace HRIS
{
    class Program
    {
        static void Main(string[] args)
        {/*
            //create a new controller
            UnitController no = new UnitController();
            List<Unit> uList = no.getUnitList("");

            //using foreach to display the unit list.
            foreach(Unit n in uList)
            {
                Console.Out.WriteLine(n.Code + "--" + n.Title);
            }
            */

            /*
            //create a new controller
            UnitController qq = new UnitController();
            List<Class> clist = qq.getUnitClassList("KIT501");

            //get the filtered list by click campus location
            List<Class> filteredList = qq.getUnitClassListByCampus(clist, "Hobart");

            //print out the filtered list
            foreach (Class a in filteredList)
            {
                Console.Out.WriteLine("{0, 10}{1, 10}{2, 10}{3, 15}{4, 10}{5, 10}{6, 10}",a.Unit_code,a.Day,a.StartEnd,a.Type,a.Room,a.StaffName,a.Campus);
            }
            */
            

            
            //create the new staff controller
            StaffController qq = new StaffController();
            List<Staff> sList = qq.getDefaultStaffList();

            //print out the list
            foreach (Staff w in sList)
            {
                Console.Out.WriteLine("{0, 10}{1, 10}{2, 10}{3, 20}{4,20}{5,20}{6,15}", w.Availability, w.Campus, w.Category, w.ConsultationTimes, w.Family_name, w.Given_name, w.Id);
            }
            

        }
    }
}
