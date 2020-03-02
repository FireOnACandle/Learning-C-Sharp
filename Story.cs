using System;

namespace Story
{
        public class Program
        {
            public static void ChoosingGender(string Male, string Female)
        {
            Console.WriteLine("");
            Console.WriteLine("Choose your gender:");
            Console.WriteLine("Male or Female?");
            Console.WriteLine("");  
        }
            public static void FemaleCharacters(string Kimberly, string Anna, string Laura)
            {
             Console.WriteLine("");
             Console.WriteLine("Choose one of these characters to play as:");

             Console.WriteLine("");
             Console.WriteLine(Kimberly);
             Console.WriteLine("");
             Console.WriteLine(Anna);
             Console.WriteLine("");
             Console.WriteLine(Laura);
             Console.WriteLine("");

            }
            public static void MaleCharacters(string Paul, string Mark, string Tom)
        {
            Console.WriteLine("");
            Console.WriteLine("Choose one of these characters to play as:");

            Console.WriteLine(Paul);
            Console.WriteLine("");
            Console.WriteLine(Mark);
            Console.WriteLine("");
            Console.WriteLine(Tom);
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            ChoosingGender("Male", "Female");
            string PlayerGender = Console.ReadLine();
            string PlayerCharacterMale;
            string PlayerCharacterFemale;

            if (PlayerGender is "Male")
            {
                MaleCharacters("Paul", "Mark", "Tom");
                PlayerCharacterMale = Console.ReadLine();
            }
            else if (PlayerGender is "Female")
            {
                FemaleCharacters("Kimberly", "Anna", "Laura");
                PlayerCharacterFemale = Console.ReadLine();
            }
        }
        }
    }

