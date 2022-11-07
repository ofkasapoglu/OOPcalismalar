using System.Collections.Generic;

namespace OOPders
{
    class Employee
    {
        private string _firstName;
        private string _lastName;
        private List<Employee> _list;
        

        public string FirstName
        {   
            //Exprention-bodied property accessors
            set { _firstName = value; } 
            get { return _firstName; }   
        }

        public string LastName
        {
            //Exprention-bodied property accessors
            get => _lastName;
            set => _lastName = value;
        }

        //Auto-implementent property (prop tabtab)
        public int Age { get; set; }

        public List<Employee> Employees  => _list;

        public Employee()
        {
            _list = new List<Employee>();
        }
        
        //Overloading...
        public Employee(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName  = lastName;
            Age = age;
            _list = new List<Employee>();
        }

        public override string? ToString()
        {
            return $"{FirstName,-20} {LastName,-15} {Age,5}";
        }

        public void Add(Employee employee)
        {
            _list.Add(employee);
        }

        public void AddRange(params Employee[] employees)
        {
            _list.AddRange(employees);
        }

        public List<Employee> GetEmployees() => _list;
        

    }
}