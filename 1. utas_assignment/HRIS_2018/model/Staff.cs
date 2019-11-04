using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.model
{
    class Staff
    {

        ////private string different with the public sting, which is not show for the public
        private string given_name;
        private string category;
        private string title;
        private string campus;
        private string phone;
        private string room;
        private string availability;
        private string id;
        private string family_name;
        private string email;
        private string photo;
        private string consultationTimes;

        private string baseInfo;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Given_name
        {
            get { return given_name; }
            set { given_name = value; }
        }

        public string Family_name
        {
            get { return family_name; }
            set { family_name = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Campus
        {
            get { return campus; }
            set { campus = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Room
        {
            get { return room; }
            set { room = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Availability
        {
            get { return availability; }
            set { availability = value; }
        }

        public string ConsultationTimes
        {
            get { return consultationTimes; }
            set { consultationTimes = value; }
        }

        public string BaseInfo
        {
            get { return baseInfo; }
            set { baseInfo = value; }
        }


    }
}
