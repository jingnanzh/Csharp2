using System.Collections.Generic;
namespace MyCSharpIntermediate
{
    public class Customer
    {
        //we do not declare like this normally, this is going to change later
        public int ID;
        public string Name;
        //public List<Order> Orders; //create a list of objects of any type
        //public List<Order> Orders = new List<Order>(); //this will initialize an empty list of orders
        public readonly List<Order> Orders = new List<Order>(); //this will make sure the order cannot be changed once initialized

        //fast way: type 'ctor' and press tab twice:
        public Customer()
        {
            Orders = new List<Order>(); //without initialize, the app will throw a nullReferenceException error
        }

        public Customer(int id)
            : this() //pass the default one above
        {
            this.ID = id;
        }

        public void Promote()
        {
            //...
            //Orders = new List<Order>(); //this will throw an error because Orders are readonly
        }

        //overload the constructor:
        public Customer(int id, string name)
            : this(id) //pass the above one 
        {
            this.Name = name;
        }
    }
    
    /*
    public class Person
    {
        public string Name;
       
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        //a static member is only accessible from the class,not an object
        public static Person Parse(string str)
        {
            //here to create a person object set the name field based on the str argument:
            var person = new Person();
            person.Name = str;

            return person;
        }
    }*/

}
