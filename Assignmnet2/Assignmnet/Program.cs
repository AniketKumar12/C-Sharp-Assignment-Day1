using System;
using System.Collections.Generic;

namespace Assignmnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            IList<string> strList = new List<string>();
            strList.Add("Tomato");
            strList.Add("Potato");
            strList.Add("ToMato");
            strList.Add("Potato");
            strList.Add("Red Tomato");
            strList.Add("Tomato Catchup");
            strList.Add("Grapes");
            strList.Add("grapes");
            strList.Add("potato");
            for (int i = 0; i < strList.Count; i++)
            {
                if (strList[i].Equals("tomato", StringComparison.InvariantCultureIgnoreCase))
                {
                    count++;
                }
                //if you are dealing with key then use Contains coz Contains search key in O(1).
                if(strList[i].Equals("Potato"))
                {
                    Console.WriteLine("index:-{0}",i);
                }
            }
            Console.WriteLine("Count:-{0}",count);
       
         }

       

        
    
    }
}
