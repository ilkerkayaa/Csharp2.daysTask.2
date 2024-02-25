using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Engin", Lastname = "Demiroğ", City = "Ankara" };

            Customer customer3 = new Customer();
            customer3.Id = 3;



            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);


        }
    }


    class Customer
    {


        public Customer()
        {
           
        }

        public Customer(int id, string firstname, string lastname, string city)
        {
            Id = id;
            FirstName = firstname;
            Lastname = lastname;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }

    }
}
