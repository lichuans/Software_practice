using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.model
{
    class Class
    {
        //private string different with the public sting, which is not show for the public
        private string start;
        private string room;
        private string campus;
        private string day;
        private string unit_code;
        private string end;
        private string startEnd;
        private string staff;
        private string type;


        private string staffName;

        public string Unit_code
        {
            get { return unit_code;  }
            set { unit_code = value;  }

        }

        public string Campus
        {
            get { return campus; }
            set { campus = value; }
        }

        public string Day
        {
            get { return day; }
            set { day = value; }

        }

        public string Start
        {
            get { return start; }
            set { start = value; }
        }

        public string End
        {
            get { return end; }
            set { end = value; }
        }

        public string StartEnd
        {
            get { return startEnd; }
            set { startEnd = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Room
        {
            get { return room; }
            set { room = value; }
        }

        public string Staff
        {
            get { return staff; }
            set { staff = value; }
        }

        public string StaffName
        {
            get { return staffName; }
            set { staffName = value; }
        }


    }
}
