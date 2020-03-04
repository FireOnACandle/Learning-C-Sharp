using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Story
{
    public class Program
    {

        public static string PlayerGender;
        public static string PlayerCharacter;
        public static string You;
        public static string Stats;
        public static double Time;
        public static string O_Clock = " o'clock";
        public static string FullTime;
        public static string Decision1;
        public static int Decision2;
        public static List<string> Fridge = new List<string>();
        public static string Pizza = "Pizza (Restores 3 Hunger (requires 30 minutes)", Bread = "Restores 2 Hunger (requires 15 minutes)", RedApple = "Restores 1 Hunger (requires 5 minutes)", GreenApple = "Restores 1 Hunger (requires 5 minutes)", SourpatchIceCream = "Restores 2 Hunger (requires 10 minutes)", Chocolate = "Restores 1 Hunger (requires 5 minutes)", Pineapple = "Restores 2 Hunger (requires 15 minutes)", Starfruit = "Restores 1 Hunger (requires 15 minutes)", Fries = "Restores 2 Hunger (requires 25 minutes";
        public static string Eat;
        public static int Hunger;
        public static double Money;

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
                BREAK();
                MaleCharacters();
                PlayerCharacterMale();
            }
            else if (PlayerGender is "Female")
            {
                BREAK();
                FemaleCharacters();
                PlayerCharacterFemale();
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
        public static void Decision2M()
        {
            Console.WriteLine("type 1 to: Go downstairs and check your fridge for something to eat (requires 5 minutes)");
            Console.WriteLine("type 2 to: Check your stats");
            Console.WriteLine("");

            Decision2 = Convert.ToInt32(Console.ReadLine());
            if (Decision2 == 1)
            {
                Console.WriteLine("Five minutes pass");
                Console.WriteLine("You go downstairs and check your fridge, it contains: ");
                FridgeDayOne();
            }
            else if (Decision2 == 2)
            {
                Decision2O();
            }
        }
        public static void Decision2O()
        {
            if (Decision2 == 2)
            {
                Console.WriteLine("");
                Console.WriteLine(Stats);
                Console.WriteLine("");
                Console.WriteLine("What would you like to do now?");
                Decision2M();
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
            BREAK();

            switch (PlayerCharacter)
            {
                case "Kimberly":
                    Console.WriteLine("");
                    Console.WriteLine("This is Kimberly.\nShe's a rather cheerful girl.\nHer likes consist of:\nSpending time with her friends\nSweet food\nTheme Parks");
                    Console.WriteLine("");
                    Console.WriteLine("Would you like to play as Kimberly? (type Yes or No)");
                    break;

                case "Anna":
                    Console.WriteLine("");
                    Console.WriteLine("This is Anna.\nShe's a rather shy girl.\nHer likes consist of:\nSpending time with her friend Emily\nJunk food\nListening to music");
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
            BREAK();
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
            BREAK();

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
            BREAK();

        }
        public static void DayOne()
        {
            Console.Clear();
            Time = 7.00D;
            if (Time >= 12.00D)
            {
                Console.WriteLine("It's noon!");
            }
            else if (Time >= 15.00D)
            {
                Console.WriteLine("It's afternoon!");
            }
            else if (Time >= 19.00D)
            {
                Console.WriteLine("It's evening");
            }
            FullTime = Time + "o'clock";
            Hunger = 2;
            if (Hunger == 1)
            {
                Console.WriteLine("Get something to eat!");
            }
            else if (Hunger == 0)
            {
                Console.WriteLine("You're going to starve if you don't get something to eat soon");
            }
            Money = 20;
            You = PlayerCharacter;
            Stats = "Stats:\nYour hunger is at: " + Hunger + "\nYou have " + Money + " dollars\nIt's " + FullTime;

            BREAK();
            Console.WriteLine(You + " wakes up in his bed at " + Time + " AM " + ", feeling hungry");
            BREAK();
            Console.WriteLine(Stats);
            BREAK();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("");

            Decision2M();
        }
        public static void Food()
        {
            switch (PlayerCharacter)
            {
                case "Paul":
                    Pizza = "Pizza (Restores 3 + 1 Hunger, requires 30 minutes)";
                    Fries = "Fries (Restores 2 + 1 Hunger, requires 20 minutes)";
                    break;

                case "Mark":
                    SourpatchIceCream = "Sourpatch Ice Cream (Restores 2 + 1 Hunger, requires 15 minutes)";
                    GreenApple = "Green Apple (Restores 1 + 1 Hunger, requires 5 minutes)";
                    break;

                case "Tom":
                    Chocolate = "Chocolate (Restores 1 + 1 Hunger, requires 5 minutes)";
                    RedApple = "Red Apple (Restores 1 + 1 Hunger, requires 5 minutes)";
                    break;

                case "Kimberly":
                    Chocolate = "Chocolate (Restores 1 + 1 Hunger, requires 5 minutes)";
                    RedApple = "Red Apple (Restores 1 + 1 Hunger, requires 5 minutes)";
                    break;

                case "Laura":
                    Pizza = "Pizza (Restores 3 + 1 Hunger, requires 30 minutes)";
                    Fries = "Fries (Restores 2 + 1 Hunger, requires 20 minutes)";
                    break;

                case "Anna":
                    Starfruit = "Starfruit (Restores 1 + 1 Hunger, requires 10 minutes)";
                    Pineapple = "Pineapple (Restores 2 + 1 Hunger, requires 15 minutes)";
                    break;
            }
        }
        public static void FridgeDayOne()
        {
            Time = Time + 0.05;
            Food();
            if (PlayerCharacter is "Paul")
            {
                Fridge.Add(Pizza);
                Fridge.Add(RedApple);
                Fridge.Add(Bread);
                foreach (string food in Fridge)
                {
                    Console.WriteLine(food);
                }
                Console.WriteLine("");
                Console.WriteLine("What do you want to eat?");
                Eat = Console.ReadLine();
                if (Eat is "Pizza")
                {
                    Fridge.Remove(Pizza);
                    Hunger = Hunger + 4;
                    Time = Time + 0.30D;
                    Console.WriteLine("");
                    Console.WriteLine("You ate the Pizza.");
                }
                else if (Eat is "Bread")
                {
                    Fridge.Remove(Bread);
                    Hunger = Hunger + 2;
                    Time = Time + 0.15D;
                    Console.WriteLine("");
                    Console.WriteLine("You ate the Bread.");
                }
                else if (Eat is "Red Apple")
                {
                    Fridge.Remove(RedApple);
                    Hunger = Hunger + 1;
                    Time = Time + 0.05D;
                    Console.WriteLine("");
                    Console.WriteLine("You ate the Apple.");
                }
                Console.WriteLine(Time);
                Console.WriteLine();
                Console.WriteLine("Would you like to eat anything else?"); // THING I'M CURRENTLY WORKING ON
                foreach (string food in Fridge)
                {
                    Console.WriteLine(food);
                }
            }
            else if (PlayerCharacter is "Mark")
            {
                Fridge.Add(SourpatchIceCream);
                foreach (string food in Fridge)
                {
                    Console.WriteLine(food);
                }
            }
            else if (PlayerCharacter is "Tim")
            {
                Fridge.Add(RedApple);
                foreach (string food in Fridge)
                {
                    Console.WriteLine(food);
                }
            }
        }

        public static void Main(string[] args)
        {
            ChoosingCharacter();
            DayOne();
        }
    }
}


