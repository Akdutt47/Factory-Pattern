using System;
using System.Data.SqlTypes;

namespace FactoryPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of phone do you want to create?");
            string userPhone = Console.ReadLine();

            
            ICallable phone = PhoneFactory.GetPhone(userPhone);
            phone.Build();
            Console.ReadLine();



           
        }
    }
}