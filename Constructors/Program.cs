namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

        }
    }

    class Customer 
    {
        public Customer()
        {
           Console.WriteLine("yapıcı blok çalıştı");
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}