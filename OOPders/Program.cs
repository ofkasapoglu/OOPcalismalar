using System;
namespace OOPders
{
    class Program
    {
        static void Main(string[] args)
        {

            var employee = new Employee();
            employee.Add(new Employee("Ömer", "Kasapoğlu", 19));
            employee.AddRange(
                new Employee("Merve","Aslan",29),
                new Employee("Elif","Dağ",40),
                new Employee("Hamza","Hancı",40),
                new Employee("Hasan","Kaan",40),
                new Employee("ZÜleyha","Göktürk",40)
            );
                
            var list = employee.GetEmployees();
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}