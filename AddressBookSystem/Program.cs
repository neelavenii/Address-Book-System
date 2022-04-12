using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Person.AddPerson();
            Person.ListPeople();
            Person1.AddPerson();
            Person1.ListPeople();
            Console.ReadLine();
        }
    }
}
