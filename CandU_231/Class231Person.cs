using System;
using System.Collections.Generic;
using System.Text;

namespace CandU_231
{
     public class Person
    {
        public string firstName;
        public string lastName;   
        
        public void SayName ()
        {
            Console.WriteLine(firstName + lastName);
        }
    }
}
