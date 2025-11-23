using System;
using System.IO;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml;
public class Program
{
    static void Main()
    {   
        //GENERAL
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int Rows = 0;
        int Cols = 0;
        Random rand = new Random();

        const string MenuTitle = "===== MAIN MENU - CODEQUEST DLC =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Increase LVL";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOption4 = "4. Show inventory";
        const string MenuOption5 = "5. Buy items";
        const string MenuOption6 = "6. Show attacks by LVL";
        const string MenuOption7 = "7. Decode ancient Scroll";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-7) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 7.";

        int op = -1;

        //CHAPTER ONE
        const string ChOneTitle = "===== CHAPTER ONE =====";
        const string ChOneBegin = "Welcome to the arcane academy! Let's start training your magic power in the next 5 days.";
        const string ChOneName = "Please choose your wizard name (max of 15 characters):";
        const string DayMsg = "--DAY {0} you meditated {1} hours, you gained {2} power points!";
        const string PowMsg = "Actual power: {0} press ENTER to continue";
        const string PowerNoob = "You have to repeat the second convocatory";
        const string PowerAvg = "You still confuse a magic wand with a spoon...";
        const string PowerPro = "You are a magic breeze invoker.";
        const string PowerHacker = "Wow! you can invoke dragons without burning the lab!";
        const string PowerGod = "Congratulations! your power is worth of an arcane master! Your knowldedge is unlimited.";
        const string NameError = "Invalid name, please input a name with at least one character and shorter than 15 characters.";
        const string Assign = "{0}, from now on you are {1}";
        const string LevelAvg = "Raoden el Elantrí";
        const string LevelNoob = "Zyn el Buguejat";
        const string LevelPro = "Arka Nullpointer";
        const string LevelHacker = "Elarion de les Brases";
        const string LevelGod = "ITB-Wizard el Gris";

        const int MaxHours = 24;
        const int MaxDays = 5;

        string currentLvl = "Normal Human";
        int numLevel = 0;
        string firstName = "";
        int totalPow = 0;
        int actualPow = 0;
        int hours = 0;

        //CHAPTER SIX:

        const string ChSixTitle = "===== CHAPTER SIX =====";
        const string ChSixBegin = "{0}, These are your wizard Spells!";
        string[][] spells = new string[][]
        {
            new string[] { "Magic Spark 💫" },
            new string[] { "Fireball 🔥", "Ice Ray 🥏", "Arcane Shield ⚕️" },
            new string[] { "Meteor ☄️", "Pure Energy Explosion 💥", "Minor Charm 🎭", "Air Strike 🍃" },
            new string[] { "Wave of Light ⚜️", "Storm of Wings 🐦" },
            new string[] { "Cataclysm 🌋", "Portal of Chaos 🌀", "Arcane Blood Pact 🩸", "Elemental Storm ⛈️" },
        };

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOption4);
            Console.WriteLine(MenuOption5);
            Console.WriteLine(MenuOption6);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);
            try
            {
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (op)
                {
                    case 1:

                        //CHAPTER 1 CODE:
                        Console.WriteLine(ChOneTitle);
                        Console.WriteLine(ChOneBegin);
                        Console.WriteLine(ChOneName);
                        firstName = Console.ReadLine() ?? "";


                        while (String.IsNullOrWhiteSpace(firstName) || firstName.Length > 15)
                        {
                            Console.WriteLine(NameError);
                            firstName = Console.ReadLine() ?? "";
                        }

                        char aux = char.ToUpper(firstName[0]);
                        string rest = firstName.Substring(1).ToLower();
                        string name = string.Concat(aux, rest);

                        for (int i = 1; i <= MaxDays; i++)
                        {
                            actualPow = rand.Next(1, 10);
                            hours = rand.Next(1, MaxHours);
                            Console.WriteLine(DayMsg, i, hours, actualPow);
                            totalPow += actualPow;
                            Console.WriteLine(PowMsg, totalPow);
                            Console.ReadLine();
                        }

                        switch (totalPow)
                        {
                            case <= 20:
                                Console.WriteLine(Assign, name, LevelNoob);
                                Console.WriteLine(PowerNoob);
                                currentLvl = LevelNoob;
                                numLevel = 0;
                                break;
                            case < 30:
                                Console.WriteLine(Assign, name, LevelAvg);
                                Console.WriteLine(PowerAvg);
                                currentLvl = LevelAvg;
                                numLevel = 1;
                                break;
                            case < 35:
                                Console.WriteLine(Assign, name, LevelPro);
                                Console.WriteLine(PowerPro);
                                currentLvl = LevelPro;
                                numLevel = 2;
                                break;
                            case < 40:
                                Console.WriteLine(Assign, name, LevelHacker);
                                Console.WriteLine(PowerHacker);
                                currentLvl = LevelHacker;
                                numLevel = 3;
                                break;
                            default:
                                Console.WriteLine(Assign, name, LevelGod);
                                Console.WriteLine(PowerGod);
                                currentLvl = LevelGod;
                                numLevel = 4;
                                break;
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;

                    case 5:
                        break;
                    case 6:
                        //CHAPTER SIX CODE:
                        Console.WriteLine(ChSixTitle);
                        Console.WriteLine(ChSixBegin, currentLvl);
                        Console.WriteLine();
                        for (int j = 0; j < spells[numLevel].Length; j++)
                        {
                            Console.WriteLine($"- {spells[numLevel][j]}.");
                        }
                        break;
                    case 7:

                        break;
                    case 0:
                        Console.WriteLine("Quitting...");
                        break;
                    case -1:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine(InputErrorMessage);
                        break;

                }
            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
            }
            Console.WriteLine();
        } while (op != 0);
    }
}
