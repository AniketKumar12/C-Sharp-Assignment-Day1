using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
   abstract public class Employee1
    {
        int _id;
        string _name;
        string _designation;
        int _experience;
        string _joing_data;
        int _salary;

     

        public abstract int Annual_Salary();

        public int ID
        {
            get { return _id; }
            set { _id = value ; }
        }
        public int Basic_Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Designation
        {
            get { return _designation; }
            set { _designation = value; }
        }
        public int Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }
        public string Joing_Date
        {
            get { return _joing_data; }
            set { _joing_data = value; }
        }
        public override string ToString()
        {
            return ID + Basic_Salary+Name+Designation+Experience+Joing_Date;
        }
        protected Employee1(int iD, int basic_Salary, string name, string designation, int experience, string joing_Date)
        {
            ID = iD;
            Basic_Salary = basic_Salary;
            Name = name;
            Designation = designation;
            Experience = experience;
            Joing_Date = joing_Date;
        }
        

    }
}
