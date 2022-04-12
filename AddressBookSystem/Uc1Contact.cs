using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
     
    
        public class Person

        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string state { get; set; }
            public string city { get; set; }
            public string pin { get; set; }
            public string email { get; set; }
            public static List<Person> people = new List<Person>();

            public static void AddPerson()
            {
                Person person = new Person();
                Console.WriteLine("Enter the first name:");
                person.FirstName = Console.ReadLine();
                Console.WriteLine("Enter the last name:");
                person.LastName = Console.ReadLine();
                Console.WriteLine("Enter the Phone number:");
                person.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter Address:");
                person.Address = Console.ReadLine();
                Console.WriteLine("Enter a state Name:");
                person.state = Console.ReadLine();
                Console.WriteLine("Enter a city Name:");
                person.city = Console.ReadLine();
                Console.WriteLine("Enter Pin number:");
                person.pin = Console.ReadLine();
                Console.WriteLine("Enter a email:");
                person.email = Console.ReadLine();

                Console.WriteLine("---------------------------------");
                people.Add(person);
            }
            private static void PrintPerson(Person person)
            {
                Console.WriteLine("First Name:" + person.FirstName);
                Console.WriteLine("last Name:" + person.LastName);
                Console.WriteLine("phoneNumber:" + person.PhoneNumber);
                Console.WriteLine("Address:" + person.Address);
                Console.WriteLine("State:" + person.state);
                Console.WriteLine("City:" + person.city);
                Console.WriteLine("Pin number" + person.pin);
                Console.WriteLine("First email:" + person.email);

                Console.WriteLine("---------------------------------");
            }
            public static void ListPeople()
            {
                if (people.Count == 0)
                {
                    Console.WriteLine("Your address book is Empty");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("here are the current people in your address book:\n");
                    foreach (var person in people)
                    {
                        PrintPerson(person);
                    }
                    Console.WriteLine("\n Press any key to continue");
                    Console.ReadLine();
                }
            }
        }
    }




