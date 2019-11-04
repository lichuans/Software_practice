using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.model;
using HRIS.service;

namespace HRIS.controller
{
    class UnitController
    {
        //connect with the Model.unit and retrive data
        public List<Unit> getUnitList(string dd)
        {
            //create a new unit service
            UnitService xd = new UnitService();
            return xd.getUnitList(dd);
        }
        //connect with mofel.class and retrive the data. this is also a way to search and operate the list.
        public List<Class> getUnitClassList(string ff)
        {
            UnitService qq = new UnitService();
            return qq.getUnitClassList(ff);
        }
        //connect with mofel.class and retrive the data. this is also a way to search and operate the list.
        public List<Class> getUnitClassListByCampus(List<Class> cList, string campus)
        {
            if (campus.Equals("All Campus"))
            {
                return cList;
            }
            else
            {
                //The way to choose the list by campus
                var chosen = from Class cs in cList
                               where (cs.Campus == campus)
                               select cs;

                return new List<Class>(chosen);
            }


        }
    }
}
