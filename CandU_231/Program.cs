using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CandU_231
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<object>> list = new List<List<object>>();
            List<object> list1 = new List<object>();
            List<object> list2 = new List<object>();


            Employee employee = new Employee();
            employee.ID = 1234;
            employee.things = "Blue Tie";
            list1.Add(employee.things);

            Employee employee2 = new Employee();
            employee2.ID = 5678;
            employee2.things = 34;
            list2.Add(employee2.things);


            list.Add(list1);
            list.Add(list2);

            foreach (List<object> objectList in list)
            {
                foreach (object obj in objectList)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }
        }
    }
}
