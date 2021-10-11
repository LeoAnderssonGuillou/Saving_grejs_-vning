using System.IO;
using System;
using System.Text.Json;

namespace Saving_grejs_övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Create new character [1] or load in old one [2]?");
            Console.WriteLine("Enter [1] or [2]");

            int choice = Utilities.GetValidChoice();
            if (choice == 1)
            {
                Character inputChar = new Character("", "", 0);
                Console.WriteLine("CREATING CHARACTER");

                Console.WriteLine("What is their name?");
                inputChar.Name = Console.ReadLine();

                Console.WriteLine("What species are they?");
                inputChar.Species = Console.ReadLine();

                Console.WriteLine("What is their power level?");
                inputChar.PowerLevel = Utilities.GetValidInput();
            }



            string customCharJson = JsonSerializer.Serialize<Character>(customChar);
            File.WriteAllText("customCharFile.json", customCharJson);


            Console.ReadLine();
        }
    }
}
