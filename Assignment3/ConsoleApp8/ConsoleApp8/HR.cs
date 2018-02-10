using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public class HR : Employee1
    {
        public HR(int iD, int basic_Salary, string name, string designation, int experience, string joing_Date) : base(iD, basic_Salary, name, designation, experience, joing_Date)
        {
           
        }

        public override int  Annual_Salary()
        {
            return(((1000 * this.Experience) + ( this.Basic_Salary)));

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

        
}

