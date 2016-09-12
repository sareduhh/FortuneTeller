using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProject
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Welcome to the mysterious Fortune Teller! Follow the instructions below to find out your accurate fortune reading.");
            Console.WriteLine("Press \"Enter\" to continue.");
            Console.ReadKey();
    
            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();

            Console.WriteLine("Next, enter your last name.");
            string lastName = Console.ReadLine();

            Console.WriteLine("Now, enter your age.");
            int userAge =int.Parse(Console.ReadLine());
            string retireInYears="None";
    
            if (userAge % 2 == 0 )
            {
                retireInYears = "40";
            }
            else 
            {
                retireInYears = "6";
            }

            Console.WriteLine("Enter the month you were born as a number from 1 to 12.");
            string moneyInBank = "None";

            int birthMonth = int.Parse(Console.ReadLine());

            if (birthMonth > 0 && birthMonth <= 4)
            {
                moneyInBank = "234,234,234";
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                moneyInBank = "5,555";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                moneyInBank = "100";
            }
            
                Console.WriteLine("Please type your favorite ROYGBIV color and hit enter. If you do not know what ROYGBIV is, type \"Help\" and hit enter.");

                string transportMode = "None";
                string favColor = Console.ReadLine();



                if (favColor.ToLower() == "help")

            {
                    Console.WriteLine("ROYGBIV is an acronym for the sequence of hues commonly described as making up a rainbow: red, orange, yellow, green, blue, indigo and violet.");
                    Console.WriteLine("Now, you may select your favorite color.");
                    favColor = Console.ReadLine();
            }

            favColor = favColor.ToLower();
                {
                    switch (favColor)
                    {
                        case "red":
                            transportMode = "built to size Titanic replica";
                            break;
                        case "orange":
                            transportMode = "Harley Davidson";
                            break;
                        case "yellow":
                            transportMode = "Ford F350";
                            break;
                        case "green":
                            transportMode = "car your Grandma used to drive";
                            break;
                        case "blue":
                            transportMode = "Death Star to drive";
                            break;
                        case "indigo":
                            transportMode = "pirate ship named The Black Pearl";
                            break;
                        case "violet":
                            transportMode = "Millenium Falcon";
                            break;
                    }
                }
              
            Console.WriteLine("Lastly, please enter the number of siblings you have.");

            int siblingsNum = int.Parse(Console.ReadLine());
            string vacationHome = "None";

            if (siblingsNum == 0)
            {
                vacationHome = "Florida";
            }
            else if (siblingsNum == 1)
            {
                vacationHome = "Grandma's House in the suburbs";
            }
                else if (siblingsNum == 2)
            {
                vacationHome = "Juneau, Alaska";
            }
            else if (siblingsNum == 3)
            {
                vacationHome = "Siberia";
            }
            else if (siblingsNum >= 3)
            {
                vacationHome = "Albuquerque";
            }
            else if (siblingsNum <0)
            {
                vacationHome = "Grandma's assisted living home";
            }
                
                     
                    Console.WriteLine("Finally, it is time for me to read your fortune. If you are ready to continue, press \"Enter\".");
                    Console.ReadKey();

                    Console.WriteLine(firstName + " " + lastName + " " + "will retire in" + " " + retireInYears + " " + "years with" + " " + "$" + moneyInBank + " " + "in the bank, a vacation home in" + " " + vacationHome + " " + "and a" + " " + transportMode + ".");

                }

                }
            }
        
    
