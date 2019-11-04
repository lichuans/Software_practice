using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.model
{
    class Unit
    {//private string different with the public sting, which is not show for the public
        private string title;
        private string code;


        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
