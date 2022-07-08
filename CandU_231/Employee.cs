using System;
using System.Collections.Generic;
using System.Text;

namespace CandU_231
{
    class Employee : Person, IQuit
    {
        public int ID { get; set; }

      public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
                return true;
            else
                return false;
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
                return false;
            else
                return true;
        }

        public void Quit ()
        {
            Console.WriteLine("Take this job and shove it!");
        }
           
        
    }
}
