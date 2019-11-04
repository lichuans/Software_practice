using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.model;
using System.Data;

namespace HRIS.database
{
    class ClassDAO
    {
        DatabaseConnection dbconn = new DatabaseConnection();

        public List<Class> getUnitClass(string unitCode )
        {
            //create a new list
            List<Class> slist = new List<Class>();

            //retrieve data from the database
            string sql = "Select c.unit_code, c.campus, c.day, c.start, c.end, c.type, c.room, c.staff, s.given_name, s.family_name from class c, staff s where c.staff = s.id";
            sql = sql + " and c.unit_code = \'" + unitCode + "\'";

            Console.Out.WriteLine(sql);

            DataTable da = dbconn.DB_Execute(sql);

            //print out the data that from the database.
            foreach(DataRow aw in da.Rows)
            {
                Class a = new Class();

                a.Unit_code = aw["unit_code"].ToString();
                a.Campus = aw["campus"].ToString();
                a.Day = aw["day"].ToString();
                a.Start = aw["start"].ToString();
                a.End = aw["end"].ToString();
                a.StartEnd = a.Start.Substring(0, 5) + "-" + a.End.Substring(0, 5);
                a.Type = aw["type"].ToString();
                a.Staff = aw["staff"].ToString();
                a.Room = aw["room"].ToString();
                a.StaffName = aw["given_name"] + " " + aw["family_name"].ToString();

                slist.Add(a);

            }

            return slist;
        }




    }
}
