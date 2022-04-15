using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class MultiplePersons
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
        public static void Modify()
        {
            if (people.Count != 0)
            {
                Console.WriteLine("Enter the contact to Modify:");
                string Modified = Console.ReadLine();
                foreach (var person in people)
                {
                    if (person.FirstName.ToUpper() == Modified.ToUpper())
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the option to modify the Properey:");
                            Console.WriteLine("Enter 1 to change the First name");
                            Console.WriteLine("Enter 2 to change the Last name");
                            Console.WriteLine("Enter 3 to change the Phone number");
                            Console.WriteLine("Enter 4 to change the Address");
                            Console.WriteLine("Enter 5 to change the State");
                            Console.WriteLine("Enter 6 to change the City");
                            Console.WriteLine("Enter 7 to change the PinCode");
                            Console.WriteLine("Enter 8 to change the email");
                            Console.WriteLine("Enter 9 to Exit");

                            int Check = Convert.ToInt32(Console.ReadLine());

                            switch (Check)
                            {
                                case 1:
                                    Console.WriteLine("Enter the New FirstName");
                                    person.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the New LastName");
                                    person.LastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the New Phone number");
                                    person.PhoneNumber = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the New Address");
                                    person.Address = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the New State");
                                    person.state = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the New City");
                                    person.city = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the New Pin code");
                                    person.pin = Console.ReadLine();
                                    break;
                                case 8:
                                    Console.WriteLine("Enter the New email");
                                    person.email = Console.ReadLine();
                                    break;
                                case 9:
                                    return;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter valid name!");
                    }
                }

            }
        }
        public static void Delete()
        {
            Console.WriteLine("Enter the First name of the person you would like to delete:");
            string Delete = Console.ReadLine();
            foreach (var person in people.ToList())
            {
                if (person.FirstName.ToUpper() == Delete.ToUpper())
                {
                    people.Remove(person);
                    Console.WriteLine("Contact is deleted");
                }
                else
                {
                    Console.WriteLine("Contact is not persent");
                }
            }
        }
        public static void ListPeople()
        {
            if (people.Count == 0)
            {
                Console.WriteLine("Your Address book is Empty");
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

    

