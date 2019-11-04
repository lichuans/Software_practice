using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.database;
using HRIS.model;

namespace HRIS.service
{
    class UnitService
    {
        
        public List<Unit> getUnitList(string queryCondition)
        {
            UnitDAO ii = new UnitDAO();

            return ii.getUnitList(queryCondition);
        }

        public List<Class> getUnitClassList(string unitCode)
        {
            ClassDAO oo = new ClassDAO();
            return oo.getUnitClass(unitCode);

            

        }


    
    }
}
