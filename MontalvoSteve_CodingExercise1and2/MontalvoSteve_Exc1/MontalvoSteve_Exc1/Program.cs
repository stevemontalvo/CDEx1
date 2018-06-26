using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Exc1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] coffeebrands = {"Starbucks","Dunkin Dounuts","Panera","Nescafe","Folgers","Paulig","PJ's Coffee","Maxwell House","Jacobs","Tassimo", "Coffeeheaven","Cafe Nero","Cafe Rico","Vinacafe", "Top Shelf Coffee","High Point","Georgia","Caffe Bene","Ricore","Illy" };

            bool ProgramIsRunning = true;

            while (ProgramIsRunning)
            {
                Console.Clear();
                //Menu Options
                Console.WriteLine("--------Menu--------\n");
                Console.WriteLine("Choose one of the following options:");
                Console.WriteLine("1. Alphabetize the list from A-Z.");
                Console.WriteLine("2. Alphabetize the list from Z-A.");
                Console.WriteLine("3. Randomly choose a cofffe brand and delete it.");
                Console.WriteLine("4. Exit\n");
                Console.WriteLine("Selection: ");

                string userInput = Console.ReadLine();
                userInput = UserValidation.IsNullOrWhiteSpace(userInput.ToLower());

                switch (userInput)
                {

                    case "1":
                    case "1.":
                    case "alphabetize the list from a-z":
                        {
                            Console.Clear();
                            Console.WriteLine("--------Alphabetize (A-Z)--------\n");
                            if (coffeebrands.Length != 0)
                            {
                                Console.WriteLine("You have chosen to alphabetize the list.");
                                Console.WriteLine();
                                //Sort Array A-Z
                                Array.Sort(coffeebrands);
                                //loop to go through the array and write it on the console.
                                foreach(var brand in coffeebrands)
                                {
                                    Console.WriteLine($"{brand}");

                                }

                            }
                            else
                            {
                                Console.WriteLine("There is nothing in the list to sort.");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "2":
                    case "2.":
                    case "alphabetize the list from z-a":
                        {
                            Console.Clear();
                            Console.WriteLine("--------Alphabetize (Z-A)--------\n");
                            //Test to make sure the array is not empty
                            if (coffeebrands.Length != 0)
                            {
                                Console.WriteLine("You have chosen to alphabetize the list in reverse.");
                                Console.WriteLine();
                                //Sort the array from A-Z
                                Array.Sort(coffeebrands);
                                //Reverse the order of the array
                                Array.Reverse(coffeebrands);
                                //Loop to go through the array and write it to the console.
                                foreach(var brand in coffeebrands)
                                {
                                    Console.WriteLine($"{brand}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("There is nothing in the list to sort.");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "3":
                    case "3.":
                    case "randomly choose a coffee brand and delete it.":
                        {
                            Console.Clear();
                            Console.WriteLine("--------Deleting Coffebrand--------\n");
                            if (coffeebrands.Length!=0)
                            {
                                Random rnd = new Random();
                                foreach (var brand in coffeebrands)
                                {
                                    int i = rnd.Next(0, coffeebrands.Length);
                                    Console.WriteLine($"{coffeebrands[i]} is being removed.");
                                    coffeebrands = coffeebrands.Where(w => w != coffeebrands[i]).ToArray();

                                }

                            }
                            else
                            {
                                Console.WriteLine("There is nothing in the list to remove!");

                            }
                            Console.WriteLine();
                        }
                        break;
                    case "4":
                    case "4.":
                    case "exit":
                        {
                            Console.WriteLine("--------Exit--------\n");
                            //user message to let them know they have chosen to exit the program
                            Console.WriteLine("You have chosen to exit the program.");
                            //Program bool change to false to exit the program.
                            ProgramIsRunning = false;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("You have not chosen a valid menu option!");
                        }
                        break;
                       
                }
                Utility.PauseBeforeContinuing();




            }
        }



    }
}
