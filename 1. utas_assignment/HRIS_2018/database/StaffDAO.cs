using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.model;
using System.Data;

namespace HRIS.database
{
    class StaffDAO
    {
        //built the connection of database
        DatabaseConnection dbconn = new DatabaseConnection();

        //sreach, operate and list the data from the model.staff
        public List<Staff> getDefaultStaffList()
        {
            List<Staff> sList = new List<Staff>();

            string sql = "SELECT id, given_name, family_name, title, campus, phone, room, email, photo, category FROM staff ";

            Console.Out.WriteLine(sql);

            DataTable dt = dbconn.DB_Execute(sql);
            //print out the list 
            foreach (DataRow dr in dt.Rows)
            {
                Staff staff = new Staff();
                staff.Id = dr["id"].ToString();
                staff.Given_name = dr["given_name"].ToString();
                staff.Family_name = dr["family_name"].ToString();
                staff.Title = dr["title"].ToString();
                staff.Campus = dr["campus"].ToString();
                staff.Phone = dr["phone"].ToString();
                staff.Room = dr["room"].ToString();
                staff.Email = dr["email"].ToString();
                staff.Photo = dr["photo"].ToString();
                staff.Category = dr["category"].ToString();
                //baseinfo is a way to combine with given name and family name.
                staff.BaseInfo = staff.Given_name + ", " + staff.Family_name + "(" + staff.Title + ")" ;

                sList.Add(staff);

            }


                return sList;
        }





    }
}
