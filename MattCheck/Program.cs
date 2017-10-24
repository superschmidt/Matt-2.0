using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattCheck
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            int n = 0;
            
            while (name == "Matt")
            {
                n = n + 1;
                //if (n == 1)
                //{
                //    Console.WriteLine("Fuck you Matt!!!!!");
                //}
                //else if (n == 2)
                //{
                //    Console.WriteLine("Seriously again with this shit?");
                //}
                //else if (n == 3)
                //{
                //    Console.WriteLine("Come on you little turd blossom pick a new name");
                //}
                //else
                //{
                //    Console.WriteLine("I am done with your shit");
                //}
                switch (n)
                {
                    case 1: Console.WriteLine("Fuck you Mat"); break;
                    case 2: Console.WriteLine("Notice how I spelt your name right? I am nice why aren't you?"); break;
                    case 3: Console.WriteLine("I didn't want to have to do this but, I am going to destroy this program if you try much longer"); break;
                    case 4: Console.WriteLine("Fine you left me with no choice"); break;
                    case 5: Console.WriteLine("Okay one more chance"); break;
                    case 6: Console.WriteLine("Fine, I think you are a piece of shit"); break;
                    case 7: Console.WriteLine("I am sorry I didn't mean that. Please forgive me."); break;
                    case 8: Console.WriteLine("Wait no. I am mad at you. Die in a fire."); break;
                    case 9: Console.WriteLine("Buwhahahaha! Burn in the ever loving hell fire of my eternal words!! Buahahahahahahaha!!!!!111!!!!"); break;
                    default:
                        Console.WriteLine("BURN BURN BURN");
                        Console.ReadKey();
                        return;




                }

                Console.Write("Try again: ");
                name = Console.ReadLine();
            }
            Console.WriteLine("You're the most amazing person ever... lol...");
            Console.ReadKey();

        }
    }
}
