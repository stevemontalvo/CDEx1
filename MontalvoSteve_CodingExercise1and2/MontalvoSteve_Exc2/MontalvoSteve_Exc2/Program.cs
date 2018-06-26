using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontalvoSteve_Exc2
{
    class Program
    {
        static void Main(string[] args)
        {
            string questionAnswer = "Starbucks";

            bool ProgramIsRunning = true;

            while (ProgramIsRunning)
            {
                Console.Clear();
                Console.WriteLine("This coffee is well known around the world!");
                Console.Write("Selection: ");
                string userAnswer = Console.ReadLine();
                userAnswer = UserValidation.IsNullOrWhiteSpace(userAnswer);

                if (userAnswer.Any(char.IsUpper) == true)
                {
                    switch (userAnswer)
                    {
                        case "Starbucks":
                            {
                                Console.WriteLine($"Congratulations you have chosen the correct answer of {questionAnswer}!");
                                ProgramIsRunning = false;
                                Utility.PauseBeforeContinuing();
                            }
                            break;


                    }
                    
                    switch (userAnswer.ToLower())
                    {
                        case "starbucks":
                            {
                                Console.WriteLine("You are very close!");
                                Console.WriteLine("HINT: You must put a capital letter in the beginning of the world ONLY!");
                                Utility.PauseBeforeContinuing();
                            }
                            break;


                        default:
                            {
                                Console.WriteLine("You have not chosen the correct answser.");
                                Console.WriteLine("HINT: This coffee brand has a star in it.");
                                Utility.PauseBeforeContinuing();
                            }
                            break;

                    }
                   
                }
                if (userAnswer.Any(char.IsUpper) == false)
                {
                    switch (userAnswer)
                    {
                        case "starbucks":
                            {
                                Console.WriteLine("You are so close!");
                                Console.WriteLine("You must put a capital letter in the beginning of the word");
                                
                            }

                            break;
                        default:
                            {
                                Console.WriteLine("You have not chosen the correct answer.");
                                Console.WriteLine("HINT: This brand has a star in it and another word for dollars.");
                                Utility.PauseBeforeContinuing();
                            }
                            break;
                    }
                }          
            }
          }
        }
    }

