using System;
using System.Collections.Generic;
using System.Text;

namespace CandU_231
{
    class Employee : Person, IQuit
    {
        public int ID;

        public int AddID;

       public void Quit ()
        {
            Console.WriteLine("Take this job and shove it!");
        }
           
        
    }
}
