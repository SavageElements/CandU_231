namespace CandU_231
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstName = "Sample";
            person.lastName = "Student";


            person.SayName();


            Employee employee = new Employee();
            employee.ID = 3456;

            employee.Quit();
        }



    }
}
