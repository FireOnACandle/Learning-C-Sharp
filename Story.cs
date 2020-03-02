using System;

namespace Story
{
        public class Program
        {
            public static void BREAK()
        {
            Console.WriteLine("-----------");
        }
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
            public static void ChoosePlayerCharacterFemale()
        {
            string PlayerCharacterFemale = Console.ReadLine();
            
            switch (PlayerCharacterFemale)
            {
                case "Kimberly":
                    Console.WriteLine("");
                    Console.WriteLine("This is Kimberly. \n");
                    break;

                case "Anna":
                    Console.WriteLine("");
                    Console.WriteLine("This is Anna. \n");
                    break;

                case "Laura":
                    Console.WriteLine("");
                    Console.WriteLine("This is Laura. \n");
                    break;
            }
        }
            public static void FemaleCharacterAttributes()
        {
            BREAK();
        }
            public static void MaleCharacters(string Paul, string Mark, string Tom)
        {
            Console.WriteLine("");
            Console.WriteLine("Choose one of these characters to play as:");

            Console.WriteLine("");
            Console.WriteLine(Paul);
            Console.WriteLine("");
            Console.WriteLine(Mark);
            Console.WriteLine("");
            Console.WriteLine(Tom);
            Console.WriteLine("");
        }
            public static void ChoosePlayerCharacterMale()
            {
            string PlayerCharacterMale = Console.ReadLine();

            switch (PlayerCharacterMale)
            {
                case "Paul":
                    Console.WriteLine("");
                    Console.WriteLine("This is Paul. \n");
                    break;

                case "Mark":
                    Console.WriteLine("");
                    Console.WriteLine("This is Mark. \n");
                    break;

                case "Tim":
                    Console.WriteLine("");
                    Console.WriteLine("This is Tom. \n");
                    break;
            }
            BREAK();
                
            }

            public static void Main(string[] args)
            {
                 ChoosingGender("Male", "Female");
                 string PlayerGender = Console.ReadLine();

                if (PlayerGender is "Male")
            {
                MaleCharacters("Paul", "Mark", "Tom");
                BREAK();
                ChoosePlayerCharacterMale();
            }
                else if (PlayerGender is "Female")
            {
                FemaleCharacters("Kimberly", "Anna", "Laura");
                BREAK();
                ChoosePlayerCharacterFemale();
                FemaleCharacterAttributes();
            }

            }
        }
    }

