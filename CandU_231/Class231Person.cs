using System;
using System.Collections.Generic;
using System.Text;

namespace CandU_231
{
     public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; } 
        
        public int ID { set; get; }
        
        public void SayName ()
        {
            Console.WriteLine(firstName + lastName);
        }
    }
}
