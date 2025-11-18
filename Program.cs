using System;
using System.Runtime.InteropServices;
public class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
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
        const string DayMsg = "--DAY {0} you meditated 10 hours, you gained {1} power points!";
        const string PowMsg = "Actual power: {0} press ENTER to continue";
        const string PowerNoob = "You are weak, you think that spoons are the same that magic wands...";
        const string PowerPro = "Almost there! At least you can conjure little magic breezes...";
        const string PowerHacker = "Yeah! your power is pretty impressive! you can invoke all sorts of dragons and conjure different spells.";
        const string PowerGod = "Congratulations! your power is worth of an arcane master! Your knowldedge is unlimited.";
        const string NameError = "Invalid name, please input a name with at least one character and shorter than 15 characters.";

        const string LevelNoob = ", The Bread Head, That's your level.";
        const string LevelPro = " Peppermint, That's your level.";
        const string LevelHacker = ", The red magician, That's your level.";
        const string LevelGod = ", Jujutsu of Oblivion, That's your level.";

        string firstName = "";
        var randomNum = new Random();
        int totalPow = 0;
        int actualPow = 0;

        //CHAPTER TWO
        const string ChTwoTitle = "===== CHAPTER TWO =====";
        const string ChTwoBegin = "Welcome to the dark forest, lets start grinding some monsters to gain level!";
        const string MonsterMsg = "A wild {0} appeared, it has {1} points of life. Lets fight! (press enter to roll the dice, enter 'quit' to exit the forest.)";
        const string LvlUp = "LEVEL UP! Your level is now {0}";
        const string MaxLvl = "You are max level! ({0})";
        const string RollMsg = "You rolled {0}, {1}'s total life: {2}";
        const string ExitForest = "Nice session! Goodbye!";
        const int MinDice = 1;
        const int MaxDice = 6;
        const int MaxMonst = 7;

        //-ascii dices:

        const string One = "   ________\r\n  /       /|   \r\n /_______/ |\r\n |       | |\r\n |   o   | /\r\n |       |/ \r\n '-------'\r\n";
        const string Two = "   ________\r\n  /       /|   \r\n /_______/ |\r\n |       | |\r\n |  o o  | /\r\n |       |/ \r\n '-------'\r\n";
        const string Three = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o     | |\r\n |   o   | /\r\n |     o |/ \r\n '-------'\r\n";
        const string Four = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n |       | /\r\n | o   o |/ \r\n '-------'\r\n";
        const string Five = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n |   o   | /\r\n | o   o |/ \r\n '-------'\r\n";
        const string Six = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n | o   o | /\r\n | o   o |/ \r\n '-------'\r\n";

        string input = "";
        Random rand = new Random();
        int roll = 0;
        int level = 0;
        string[,] monsterList = {{"Wandering skeleton", "3"}, {"Forest goblin", "5"}, {"Green Slime", "10"}, {"Ember Wolf", "11"}, {"Giant Spider", "18"}, {"Iron Golem", "15"}, {"Lost Necromancer", "20" }, { "Ancient Dragon", "50"} };


        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);
            try
            {
                op = Convert.ToInt32(Console.ReadLine());
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

                        for (int i = 1; i <= 5; i++)
                        {
                            actualPow = randomNum.Next(1, 10);
                            Console.WriteLine(DayMsg, i, actualPow);
                            totalPow += actualPow;
                            Console.WriteLine(PowMsg, totalPow);
                            Console.ReadLine();
                        }

                        switch (totalPow)
                        {
                            case <= 20:
                                Console.WriteLine(PowerNoob);
                                Console.WriteLine(name + LevelNoob);
                                break;
                            case <= 30:
                                Console.WriteLine(PowerPro);
                                Console.WriteLine(name + LevelPro);
                                break;
                            case <= 40:
                                Console.WriteLine(PowerHacker);
                                Console.WriteLine(name + LevelHacker);
                                break;
                            case <= 47:
                                Console.WriteLine(PowerGod);
                                Console.WriteLine(name + LevelGod);
                                break;
                            default:
                                Console.WriteLine(PowerGod);
                                Console.WriteLine(name + LevelGod);
                                break;
                        }

                        break;
                    case 2:
                        //CHAPTER 2 CODE:

                        Console.WriteLine(ChTwoTitle);
                        Console.WriteLine(ChTwoBegin);
                        do
                        {
                            int aux2 = rand.Next(0, MaxMonst);
                            int life = Convert.ToInt32(monsterList[aux2, 1]);
                            Console.WriteLine(MonsterMsg, monsterList[aux2, 0], life);
                            input = Convert.ToString(Console.ReadLine() ?? "");
                            if (input == "quit")
                            {
                                Console.WriteLine(ExitForest);
                            }
                            else
                            { 
                                while (life > 0) 
                                {
                                    roll = rand.Next(MinDice, MaxDice);
                                    life = life - roll;
                                    switch (roll) 
                                    {
                                        case 1:
                                            Console.WriteLine(One);
                                            break;
                                        case 2:
                                            Console.WriteLine(Two);
                                            break;
                                        case 3:
                                            Console.WriteLine(Three);
                                            break;
                                        case 4:
                                            Console.WriteLine(Four);
                                            break;
                                        case 5:
                                            Console.WriteLine(Five);
                                            break;
                                        default:
                                            Console.WriteLine(Six);
                                            break;
                                    }
                                    Console.WriteLine(RollMsg, roll, monsterList[aux2, 0], life);
                                    Console.ReadLine();
                                }
                                if (level < 5)
                                {
                                    level++;
                                    Console.WriteLine(LvlUp, level);
                                }
                                else 
                                {
                                    Console.WriteLine(MaxLvl, level);
                                }
                            }
                        } while (input != "quit");
                        break;
                    case 3:
                        
                            break;
                    case 4:

                        break;

                    case 5:

                        break;
                    case 6:

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
        } while (op != 0);
    }
}
