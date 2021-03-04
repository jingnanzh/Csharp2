using System;

namespace MyCSharpIntermediate
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirmail = 2,
        Express = 3
    }
    partial class Program
    {

        static void Main(string[] args)
        {
            //class 2 exercise1: design a stopwatch
            var method = ShippingMethod.Express;
            var method2 = ShippingMethod.RegularAirMail;
            Console.WriteLine((ShippingMethod)method);
            Console.WriteLine((ShippingMethod)method2);
            Console.WriteLine((ShippingMethod)ShippingMethod.Express);
            Console.WriteLine();
            Console.WriteLine((int)method);
            Console.WriteLine(method.ToString());
            Console.WriteLine(method); //console.writeline will always convert an object to a string

            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);
            Console.WriteLine((ShippingMethod)2);

            Console.WriteLine(); //write a break line

            //concert a string to an enum, you will need to use parsing
            var methodName = "Express";
            var method3 = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            var method4 = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodId.ToString());
            Console.WriteLine((ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName) );
            Console.WriteLine(method4);
        }


        static void Indexer()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "mosh";
            Console.WriteLine(cookie["name"]);
        }
        static void AgeCal()
        {
            var person = new Person(new DateTime(2005, 3, 3)); //Person now has a parameter
            //person.Birthdate = new DateTime(2005, 3, 3);
            Console.WriteLine(person.Age);
            /*
                        person.SetBirthdate(new DateTime(2005, 3, 3));
                        Console.WriteLine(person.GetBirthdate());
            */
        }

        static void NewOrder()
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            
            //customer.Promote(); //this will set the order to 0;
            
            Console.WriteLine(customer.Orders.Count);
        }
        static void OutModifier()
        {
            //out modifier
            //var number = int.Parse("abc"); //this will throw an error
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("conversion fail");
        }

        static void UserParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 3, 4, 5, 6 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                //point.Move(new Point(40,60));
                point.Move(null); //this will throw a nullReferenceException

                Console.WriteLine("point is at {0}, {1}, ", point.X, point.Y);


                point.Move(100, 200);
                Console.WriteLine("point is at {0}, {1}, ", point.X, point.Y);

            }
            catch (Exception)
            {

                Console.WriteLine("an unecpected error occured");
            }
        }

        static void AddCustomer()
        {
            var customer = new Customer(1, "John");

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.ID);
            Console.WriteLine(customer.Name);
        }
    }
}
