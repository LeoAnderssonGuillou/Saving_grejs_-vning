using System.Net;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Saving_grejs_övning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            string characterPath;
            string characterString;

            bool reading = true;
            int i = 0;
            characterPath = $@"Characters\char{i}.json";
            characterString = File.ReadAllText(characterPath);
            Console.WriteLine(characterString);
            //Console.ReadLine();
            Character c = JsonSerializer.Deserialize<Character>(characterString);
            // Console.WriteLine($"Text");
            Console.ReadLine();


            characters.Add(JsonSerializer.Deserialize<Character>(characterString));
            //Console.ReadLine();
            while (reading)
            {
                try
                {
                    Console.WriteLine("Trying...");
                    characterPath = $@"Characters\char{i}.json";
                    characters.Add(JsonSerializer.Deserialize<Character>(characterPath));

                    Console.WriteLine("Read in character");
                }
                catch
                {
                    reading = false;
                    Console.WriteLine("That's enough of that");
                }
                i++;
            }
            Console.WriteLine("CHARACTERS:");
            foreach (Character cha in characters)
            {
                Console.WriteLine(cha.Name);
            }
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Create new character [1] or load in old one [2]?");
            Console.WriteLine("Enter [1] or [2]");

            int choice = Utilities.GetValidChoice();
            if (choice == 1)
            {
                Character inputChar = new Character();
                Console.WriteLine("CREATING CHARACTER");

                Console.WriteLine("What is their name?");
                inputChar.Name = Console.ReadLine();

                Console.WriteLine("What species are they?");
                inputChar.Species = Console.ReadLine();

                Console.WriteLine("What is their power level?");
                inputChar.PowerLevel = Utilities.GetValidInput();

                //characters.Add(new Character(inputChar.Name, inputChar.Species, inputChar.PowerLevel));
                Character testChar = new Character(inputChar.Name, inputChar.Species, inputChar.PowerLevel);

                string charString = JsonSerializer.Serialize<Character>(inputChar);
                int nextCharIndex = characters.Count;
                File.WriteAllText($@"Characters\char{nextCharIndex}.json", charString);

            }



            // string customCharJson = JsonSerializer.Serialize<Character>(customChar);
            // File.WriteAllText("customCharFile.json", customCharJson);


            Console.ReadLine();
        }
    }
}
