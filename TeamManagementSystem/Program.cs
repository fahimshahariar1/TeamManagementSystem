using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManagementSystem
{
    internal class Program
    {

        class Person
        {
            public string name { get; protected set; }
            public int age { get; protected set; }

            public Person(String name, int age)
            {

                this.name = name;
                this.age = age;

            }

            public String returnDetails()
            {

                return name + " - " + age;
 
            }

            public void setName(String name)
            {
                this.name = name;
            }
            public void setAge(int age)
            {
                this.age = age;
            }

        }


        class Manager
        {
            public List<Person> people;

            public Manager() 
            {
            
                people = new List<Person>();
                printMenu();

            }

            public void printMenu() {

                Console.WriteLine("Welcome to Integration Team Management System" + Environment.NewLine);
                Console.WriteLine("1. Print All Members");
                Console.WriteLine("2. Add Member");
                Console.WriteLine("3. Edit Memeber");
                Console.WriteLine("4. Search Member");
                Console.WriteLine("5. Remove Member");
                Console.WriteLine("6. Exit");

                Console.WriteLine();
                Console.Write("Enter an Option: ");
             


                if (int.TryParse(Console.ReadLine(), out int menuOption))

                {
                    Console.WriteLine(menuOption);
                }
                else {

                    Console.WriteLine("Incorrect Option");
                    Console.WriteLine("Press <Enter> to try again");
                    Console.ReadLine();
                    Console.Clear();
                    printMenu();

                }

            }


        }


        static void Main(string[] args)
        {

           
            Manager manager= new Manager();

            
             

            Console.ReadLine();
        }
    }
}
