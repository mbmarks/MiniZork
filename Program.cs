using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniZork
{
    class Program
    {
        static void Main(string[] args)
        {
            openfield:
            Console.WriteLine("You are standing in an open field west of a white house,");
            Console.WriteLine("With a boarded front door.");
            Console.WriteLine("There is a small mailbox here.");
            Console.Write("Go to the house, or open the mailbox? ");

            String action = Console.ReadLine();

            if (action.Equals("open the mailbox"))
            {
                Console.WriteLine("You open the mailbox.");
                Console.WriteLine("It's really dark in there.");
                Console.Write("Look inside or stick your hand in? ");
                action = Console.ReadLine();

                if (action.Equals("look inside"))
                {
                    Console.WriteLine("You peer inside the mailbox.");
                    Console.WriteLine("It's really very dark. So ... so very dark.");
                    Console.Write("Run away or keep looking? ");
                    action = Console.ReadLine();

                    if (action.Equals("keep looking"))
                    {
                        Console.WriteLine("Turns out, hanging out around dark places isn't a good idea.");
                        Console.WriteLine("You've been eaten by a grue.");
                        Console.WriteLine("You have died.");
                        Console.ReadLine();
                        return;
                    }
                    else if (action.Equals("run away"))
                    {
                        Console.WriteLine("You run away screaming across the fields - looking very foolish.");
                        Console.WriteLine("But you're alive. Possibly a wise choice.");
                        goto openfield;
                    }
                }
                else if (action.Equals("stick your hand in")) 
                {
                    Console.WriteLine("You feel a bite on your finger, it really hurts.");
                    Console.Write("Pull hand out or scream? ");
                    action = Console.ReadLine();

                    if (action.Equals("pull hand out"))
                    {
                        Console.WriteLine("There is a bite mark on your finger, you run back to the field.");
                        goto openfield;
                    } 
                    else if (action.Equals("scream"))
                    {
                        Console.WriteLine("You scream as loud as you can.");
                        Console.WriteLine("You feel yourself getting tugged into the mailbox.");
                        Console.WriteLine("You are eaten by a grue.");
                        Console.ReadLine();
                        return;
                    }
                }
            }
            else if (action.Equals("go to the house")) 
            {
                house:
                Console.WriteLine("You are standing infront of a big house painted white.");
                Console.WriteLine("There is a window and the door is boarded up.");
                Console.WriteLine("Pry the door open or look in the window?");
                action = Console.ReadLine();

                if (action.Equals("pry the door open"))
                {
                    Console.WriteLine("You are able to pull the boards off with ease.");
                    Console.WriteLine("You enter the house and feel safe.");
                    Console.WriteLine("You have won!");
                    Console.ReadLine();
                    return;
                }
                else if (action.Equals("look in the window"))
                {
                    Console.WriteLine("You look in the window and can see someone standing there.");
                    Console.WriteLine("You recognize them as the president of the United States.");
                    Console.WriteLine("It is a white house after all.");
                    goto house; 
                }

            }
        }
    }
}
