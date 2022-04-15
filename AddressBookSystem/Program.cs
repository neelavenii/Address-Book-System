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
            while (true)
            {
                Console.WriteLine("select numbers \n1)Add Contact\n2)Modify Person\n3)listPeople\n4)delete person");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        Person2.AddPerson();
                        break;
                    case 2:
                        Person2.Modify();
                        break;
                    case 3:
                        Person2.ListPeople();
                        break;
                    case 4:
                        Person3.Delete();
                        break;
                }
            }
        }
    }
}
