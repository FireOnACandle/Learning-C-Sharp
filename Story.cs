using System;

namespace Story
{
    public class Program
    {
        public static string PlayerGender;
        public static string PlayerCharacter;
        public static string Decision1;
        public static string Hunger;

        public static void BREAK()
        {
            Console.WriteLine("-----------");
        }
        public static void ChoosingCharacter(string Male = "Male", string Female = "Female")
        {
            Console.WriteLine("");
            Console.WriteLine("Choose your gender:");
            Console.WriteLine("Male or Female?");
            Console.WriteLine("");
            PlayerGender = Console.ReadLine();

            if (PlayerGender is "Male")
            {
                MaleCharacters();
                BREAK();
                PlayerCharacterMale();
                BREAK();
            }
            else if (PlayerGender is "Female")
            {
                FemaleCharacters();
                BREAK();
                PlayerCharacterFemale();
                BREAK();
            }
            else
            {
                ChoosingCharacter();
            }

            Decision1 = Console.ReadLine();

            if (Decision1 is "Yes")
            {
                Console.WriteLine("");
                Console.WriteLine("Alright, let the first day begin");
            }
            else if (Decision1 is "No")
            {
                ChoosingCharacterSITUATIONAL();
            }
            else
            {
                Decision1SITUATIONAL();
            }
        }
        public static void ChoosingCharacterSITUATIONAL()
        {
            Console.WriteLine("");
            Console.WriteLine("Choose your gender:");
            Console.WriteLine("Male or Female?");
            Console.WriteLine("");
            PlayerGender = Console.ReadLine();

            if (PlayerGender is "Male")
            {
                MaleCharacters();
                BREAK();
                PlayerCharacterMale();
                BREAK();
            }
            else if (PlayerGender is "Female")
            {
                FemaleCharacters();
                BREAK();
                PlayerCharacterFemale();
                BREAK();
            }
            else
            {
                ChoosingCharacter();
            }
            Decision1 = Console.ReadLine();

            if (Decision1 is "Yes")
            {
                Console.WriteLine("");
                Console.WriteLine("Alright, let the first day begin");
            }
            else if (Decision1 is "No")
            {
                ChoosingCharacterSITUATIONAL();
            }
            else
            {
                Decision1SITUATIONAL();
            }
        }
        public static void Decision1SITUATIONAL()
        {
            Decision1 = Console.ReadLine();
            if (Decision1 is "Yes")
            {
                Console.WriteLine("");
                Console.WriteLine("Alright, let the first day begin");
            }
            else if (Decision1 is "No")
            {
                ChoosingCharacterSITUATIONAL();
            }
            else
            {
                Decision1SITUATIONAL();
            }
        }

        public static void FemaleCharacters(string Kimberly = "Kimberly", string Anna = "Anna", string Laura = "Laura")
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
        public static void PlayerCharacterFemale()
        {
            Console.WriteLine("If you want to go back, type: back");
            PlayerCharacter = Console.ReadLine();

            switch (PlayerCharacter)
            {
                case "Kimberly":
                    Console.WriteLine("");
                    Console.WriteLine("This is Kimberly.\nShe's a rather cheerful girl.\nHer likes consist of:\nSpending time with her friends\nSweet foods\nTheme Parks");
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to play as Kimberly? (type Yes or No)");
                    break;

                case "Anna":
                    Console.WriteLine("");
                    Console.WriteLine("This is Anna.\nShe's a rather shy girl.\nHer likes consist of:\nSpending time with her friend Emily\nPizza\nListening to music");
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to play as Anna? (type Yes or No)");
                    break;

                case "Laura":
                    Console.WriteLine("");
                    Console.WriteLine("This is Laura.\nShe's pretty adventurous.\nHer likes consist of:\nTrying new things\nEating exotic foods\nExiting activities");
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to play as Laura? (type Yes or No)");
                    break;

                case "back":
                    ChoosingCharacter();
                    break;

                default:
                    PlayerCharacterFemale();
                    break;
            }
        }
        public static void MaleCharacters(string Paul = "Paul", string Mark = "Mark", string Tom = "Tom")
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
        public static void PlayerCharacterMale()
        {
            Console.WriteLine("If you want to go back, type: back");
            PlayerCharacter = Console.ReadLine();

            switch (PlayerCharacter)
            {
                case "Paul":
                    Console.WriteLine("");
                    Console.WriteLine("This is Paul.\nPaul is a funny and pretty positive guy.\nHis likes consist of:\nPlaying his guitar\nSpending time with his friends\nJunk food");
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to play as Paul? (type Yes or No)");
                    break;

                case "Mark":
                    Console.WriteLine("");
                    Console.WriteLine("This is Mark.\nMark is a pretty serious person\nHis likes consist of:\nStudying\nListening to music\nSour foods");
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to play as Mark? (type Yes or No)");
                    break;

                case "Tom":
                    Console.WriteLine("");
                    Console.WriteLine("This is Tom.\nHe's a rather shy person\nHis likes consist of:\nPlaying video games\nSpending time with his friend Frederick\nSweet foods");
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to play as Tom? (type Yes or No)");
                    break;

                case "back":
                    ChoosingCharacter();
                    break;

                default:
                    PlayerCharacterMale();
                    break;
            }
        }

        public static void Main(string[] args)
        {
            ChoosingCharacter();
        }
    }
}


