using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm
{
    internal class Members
    {

        private string name, surname, DOB, gender, phonenumber, address, trainingprogram, startdate, enddate;
        private int memberID;

        public Members(int memberID,string name, string surname, string dOB, string gender, string phonenumber, string address, string trainingprogram, string startdate, string enddate)
        {
            this.MemberID = memberID;
            this.Name = name;
            this.Surname = surname;
             this.DOB1 = dOB;
            this.Gender = gender;
            this.Phonenumber = phonenumber;
            this.Address = address;
            this.Trainingprogram = trainingprogram;
            this.Startdate = startdate;
            this.Enddate = enddate;
            
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Address { get => address; set => address = value; }
        public string Trainingprogram { get => trainingprogram; set => trainingprogram = value; }
        public string Startdate { get => startdate; set => startdate = value; }
        public string Enddate { get => enddate; set => enddate = value; }
        public int MemberID { get => memberID; set => memberID = value; }
    }
}
