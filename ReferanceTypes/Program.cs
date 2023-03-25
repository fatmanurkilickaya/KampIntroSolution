namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Person person1 = new Person();
            person1.Name = "Nur";
            person1.LastName = "Kılıçkaya";

            Person person2 = new Person();
            person2.Name = "Cuma";

            Person person3 = new Person();
            person3.Name = "Hilal";

            person1 = person2;
            person1.Name = "Fatma Nur";
            Console.WriteLine(person2.Name);
            Console.WriteLine(person1.Name);

            Customer customer = new Customer();
            customer.Name = "Kübra";

            Employee employee = new Employee();
            employee.Name = "Merve";
            employee.LastName = "Maviş";

            Person person4 = customer;
            customer.Name = "Ahmet";
            customer.CreditCardNumber = "1";    
            

            Console.WriteLine(((Customer)person4).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }
    }

    class Person 
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    
    }
    class Customer :Person
    { 
        public string CreditCardNumber { get; set; }    
    }

    class Employee : Person
    { 
        public int EmployeeNurber { get; set; }
    }

    class PersonManager 
    {
        public void Add(Person person) 
        {
            Console.WriteLine(person.Name);

        }
    
    }
}