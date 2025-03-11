//#############################################################################################################
/*
 * Matthew
 * St10258193
 * Group 2
 * PROG6221
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    //*****************************************************************************************************
    internal class Program
    {
        static List<IAnimal> party = new List<IAnimal>();
        static Random random = new Random();

        static void Main()
        {
            Console.WriteLine("Welcome to Devils Forest!");
            GameLoop();
        }

        static void GameLoop()
        {
            //loopstart here
            while (true)
            {
                IAnimal encounteredAnimal = GetRandomAnimal();
                Console.WriteLine($"\nYou encounter a {encounteredAnimal.Name}!");
                encounteredAnimal.Talk();
                Console.Write("Will you Attack / Feed / Run? ");
                string choice = Console.ReadLine()?.ToLower();

                if (choice == "attack")
                {
                    encounteredAnimal.Attack();
                    encounteredAnimal.IsAlive = false;
                    Console.WriteLine($"You have slain the {encounteredAnimal.Name}.");
                }

                else if (choice == "feed")
                {
                    if (encounteredAnimal.IsTrained)
                    {
                        Console.Write("Give it a name: ");
                        encounteredAnimal.Name = Console.ReadLine();
                        party.Add(encounteredAnimal);
                        Console.WriteLine($"{encounteredAnimal.Name} has joined your party!");
                    }
                    else
                    {
                        Console.WriteLine($"The {encounteredAnimal.Name} is not trainable. It walks away.");
                    }
                }

                else if (choice == "run")
                {
                    Console.WriteLine("You have escaped.");
                    break;
                }
            }
        }

        static IAnimal GetRandomAnimal()
        {
            int randomNumber = random.Next(3);

            if (randomNumber == 0)
                return new Wolf("Wild Wolf");
            else if (randomNumber == 1)
                return new Boar("Fierce Boar");
            else
                return new GiantBat("Giant Bat");
        }
    }
}
//************************************************MAR26 END OF FILE********************************************