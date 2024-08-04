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
            public int id { get; protected set; }

            public Person(String name, int id)
            {

                this.name = name;
                this.id = id;

            }

            public String returnDetails()
            {

                return name + " - " + id;
 
            }

            public void setName(String name)
            {
                this.name = name;
            }
            public void setId(int id)
            {
                this.id = id;
            }

        }


        class Manager
        {
            public List<Person> people;

            public Manager() 
            {

                people = new List<Person>() { };


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
                    if (menuOption == 1)
                    {
                        PrintAll();
                    }
                    else if (menuOption == 2)
                    {
                        AddMember();
                    }
                    else if(menuOption == 3)
                    {
                        EditMember();
                    }
                    else if (menuOption == 4)
                    {
                        SearchMemebr();
                    }
                    else if (menuOption == 5)
                    {
                        RemoveMember();
                    }

                    printMenu();
                    
                }
                else {

                    Console.WriteLine("Incorrect Option");
                    Console.WriteLine("Press <Enter> to try again");
                    Console.ReadLine();
                    Console.Clear();
                    printMenu();

                }

            }


            public void PrintAll()
            {


                StartOption("All Integration Team Members");

                if (people.Count == 0)
                {
                    Console.WriteLine("No Members added, Use option 2 to create member");
                }

                for (int i = 0; i < people.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + people[i].returnDetails());
                }

                FinishedOption();
            }
             public void AddMember()
            {
                StartOption("Add new member to the Integration Team");


                try
                {
                    Console.Write("Enter a Name: ");
                    String nameInput = Console.ReadLine();

                    Console.Write("Enter an Ding ID: ");
                    int idInput = Convert.ToInt32(Console.ReadLine());


                    if (!String.IsNullOrEmpty(nameInput))
                    {
                        if (idInput > 0 && idInput <= 9999)
                        {
                            
                            people.Add(new Person(nameInput, idInput));

                            Console.WriteLine(Environment.NewLine+"Added Successfully");

                            FinishedOption();

                        }
                        else
                        {
                           
                            OutputMessage(Environment.NewLine + "Id must be 0 - 9999" + Environment.NewLine);
                            AddMember();
                        }
                    }
                    else
                    {

                        OutputMessage(Environment.NewLine  + "Name field can not be empty." + Environment.NewLine);


                    }



                }
                catch (Exception)
                {
                    OutputMessage(Environment.NewLine + "Something Went Wrong" + Environment.NewLine);
                    
                    AddMember();

                }



            }

            public void EditMember()
            {
                StartOption("Edit a Member");

                FinishedOption();
            }

            public void SearchMemebr()
            {
                StartOption("Search Member");

                FinishedOption();
            }
            public void RemoveMember()
            {
                StartOption("Remove a Member");

                FinishedOption();
            }

            public void FinishedOption () {

                Console.WriteLine();
                Console.WriteLine("Press <Enter> to return back to the menu.");
                Console.ReadLine();
                Console.Clear();

            }

            public void StartOption(String message)
            {

                Console.Clear();
                Console.WriteLine(message + Environment.NewLine);

            }

            public void OutputMessage(String message)
            {
                Console.WriteLine(message + Environment.NewLine + "Press <Enter> to return back to the menu.");
                Console.ReadLine ();
                Console.Clear();
            }
        }


        static void Main(string[] args)
        {

           
            Manager manager= new Manager();

            
             

            Console.ReadLine();
        }
    }
}
