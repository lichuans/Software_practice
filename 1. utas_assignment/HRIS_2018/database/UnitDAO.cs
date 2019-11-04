using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HRIS.model;

namespace HRIS.database
{
    class UnitDAO
    {
        //create a new connection 
        DatabaseConnection dbconn = new DatabaseConnection();

        //search, list and operate the list fron the Model.unit
        public List<Unit> getUnitList(string queryCondition)
        {
            //create the new list 
            List<Unit> uList = new List<Unit>();

            string sql = "select code, title from unit ";

            if(queryCondition != null && !queryCondition.Equals(""))
            {
                // this \' is print out this '
                sql = sql + "where code like \'%" + queryCondition + "%\' or title like \'%" + queryCondition + "%\'";
            }

            sql = sql + " order by code asc";

            Console.Out.WriteLine(sql);

            DataTable dt = dbconn.DB_Execute(sql);
            //print out the list
            foreach(DataRow dr in dt.Rows)
            {
                Unit u = new Unit();
                u.Code = dr["code"].ToString();
                u.Title = dr["title"].ToString();

                uList.Add(u);
            }

            return uList;
        }





    }
}
