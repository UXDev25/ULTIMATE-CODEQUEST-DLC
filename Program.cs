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

        //CHAPTER TWO
        const string ChTwoTitle = "===== CHAPTER TWO =====";
        const string ChTwoBegin = "Welcome to the dark forest, lets start grinding some monsters to gain level!";
        const string MonsterMsg = "A wild {0} appeared, it has {1} points of life. Lets fight! (press enter to roll the dice, enter '0' to exit the forest.)";
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
        int roll = 0;
        int level = 0;
        string[,] monsterList = {{"Wandering skeleton", "3"}, {"Forest goblin", "5"}, {"Green Slime", "10"}, {"Ember Wolf", "11"}, {"Giant Spider", "18"}, {"Iron Golem", "15"}, {"Lost Necromancer", "20" }, { "Ancient Dragon", "50"} };


        //CHAPTER THREE:

        const string ChThreeTitle = "===== CHAPTER THREE =====";
        const string ChThreeBegin = "Lets mine some gold! Enter the coordinates of the chunk you want to mine, you got {0} attemps";
        const string CoordError = "Invalid coordinates, try again";
        const string Miss = "You found nothing... Attemps left: {0} (Enter the coordinates of the chunk you want to mine)";
        const string Hit = "You found gold! Bits won: {0}. Attemps left: {1}";
        const string Dumb = "You alredy checked this chunk!. Attemps left: {0}";
        const string EndMine = "End of the session, your final bit score: {0}";
        const int MaxAtt = 5;
        const int MineProb = 60;

        int[,] coinMap = new int[6,6];
        int x = 0;
        int y = 0;
        int totalBits = 0;
        bool validCords = false;

        //CHAPTER FOUR:
        const string ChFourTitle = "===== CHAPTER FOUR =====";
        const string ChFourBegin = "This is your inventory: ";
        const string NoInv = "- You have no items yet. -";
        const string ShowInv = "- These are your current items: -";

        string[] inventory = new string[0];

        //CHAPTER FIVE:

        const string ChFiveTitle = "===== CHAPTER FIVE =====";
        const string ChFiveBegin = "Welcome to the shop! To buy an item, insert the number corresponding to that item, insert '0' to leave.";
        const string Bits = "Total bits: {0}";
        const string PurchaseError = "Invalid item, try again.";
        const string Ins = "Insufficent Bits, go to the mine to get more bits.";
        const string PurchaseMsg = "You bought a {0} for {1} bits!";
        const string ExitShop = "See you next time!";

        string[,] shop = { { "Objecte", "Preu (Bits)"}, { "Iron dagger", "30"}, { "Healing Potion", "10" }, { "Ancient Key", "50" }, { "Crossbow", "40" }, { "Metal Shield", "20" } };
        int buyId = -1;
        bool validId = false;

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
                        //CHAPTER 2 CODE:

                        Console.WriteLine(ChTwoTitle);
                        Console.WriteLine(ChTwoBegin);
                        do
                        {
                            int aux2 = rand.Next(0, MaxMonst);
                            int life = Convert.ToInt32(monsterList[aux2, 1]);
                            Console.WriteLine(MonsterMsg, monsterList[aux2, 0], life);
                            input = Convert.ToString(Console.ReadLine() ?? "");
                            if (input == "0")
                            {
                                Console.WriteLine(ExitForest);
                            }
                            else
                            {
                                while (life > 0)
                                {
                                    roll = rand.Next(MinDice, MaxDice);
                                    life = life - roll;
                                    if (life < 0){ life = 0; }
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
                        //CHAPTER 3 CODE:
                        string[,] playerMap = { { "  "," 1"," 2"," 3"," 4"," 5"}, { "-1", "➖", "➖", "➖", "➖", "➖" }, { "-2", "➖", "➖", "➖", "➖", "➖" }, { "-3", "➖", "➖", "➖", "➖", "➖" } , { "-4", "➖", "➖", "➖", "➖", "➖" }, { "-5", "➖", "➖", "➖", "➖", "➖" } };
                        Console.WriteLine(ChThreeTitle);
                        Console.WriteLine(ChThreeBegin, MaxAtt);
                        Rows = 6;
                        Cols = 6;
                        for (int i = 0; i < Rows; i++)
                        {
                            for (int j = 0; j < Cols; j++)
                            {
                                Console.Write($"{playerMap[i, j]}|");
                                int genCoin = rand.Next(1, 100);
                                if (genCoin < MineProb)
                                {
                                    coinMap[i, j] = 1;
                                }
                                else 
                                {
                                    coinMap[i, j] = 0;
                                }
                            }
                            Console.WriteLine();
                            if (i == 0)
                            {
                                Console.WriteLine("------------------");
                            }
                        }
                        for (int i = MaxAtt - 1; i >= 0; i--)
                        {
                            while (validCords == false)
                            {
                                Console.Write("x: ");
                                bool isXInt = Int32.TryParse(Console.ReadLine(), out x);
                                Console.Write("y: ");
                                bool isYInt = Int32.TryParse(Console.ReadLine(), out y);
                                x = Math.Abs(x);
                                y = Math.Abs(y);
                                validCords = isYInt && isXInt && x < 6 && x > 0 && y < 6 && y > 0;
                                if (!validCords)
                                {
                                    Console.WriteLine(CoordError);
                                }
                            }
                            switch (coinMap[y, x]) 
                            {
                                case 1:
                                    int bits = rand.Next(5, 50);
                                    totalBits = totalBits + bits;
                                    Console.WriteLine(Hit, bits, i);
                                    playerMap[y, x] = "🪙";
                                    coinMap[y, x] = 2;
                                    break;
                                case 2:
                                    Console.WriteLine(Dumb, i);
                                    break;
                                default:
                                    Console.WriteLine(Miss, i);
                                    playerMap[y, x] = "❌";
                                    coinMap[y, x] = 2;
                                    break;
                            }
                            for (int k = 0; k < Rows; k++)
                            {
                                for (int l = 0; l < Cols; l++)
                                {
                                    Console.Write($"{playerMap[k, l]}|");
                                }
                                Console.WriteLine();
                                if (k == 0)
                                {
                                    Console.WriteLine("------------------");
                                }
                            }
                            validCords = false;
                        }
                        Console.WriteLine(EndMine, totalBits);
                        break;
                    case 4:
                        //CHAPTER FOUR CODE:
                        Console.WriteLine(ChFourTitle);
                        Console.WriteLine(ChFourBegin);
                        bool hasItems = inventory.Length == 0 ? false : true;
                        if (!hasItems)
                        {
                            Console.WriteLine(NoInv);
                        }
                        else 
                        {
                            foreach (string i in inventory)
                            {
                                Console.WriteLine($"- {i}");
                            }
                        }
                        break;

                    case 5:
                        //CHAPTER FIVE CODE:
                        Console.WriteLine(ChFiveTitle);
                        Console.WriteLine(ChFiveBegin);
                        Console.WriteLine(Bits);
                        Rows = 6;
                        Cols = 2;
                        for (int i = 0; i < Rows; i++)
                        {
                            for (int j = 0; j < Cols; j++)
                            {
                                Console.Write($" | {shop[i, j],-15} | ");
                            }
                            Console.WriteLine();
                            if (i == 0)
                            {
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        do
                        {
                            validId = Int32.TryParse(Console.ReadLine(), out buyId);
                            if (!validId || buyId > 5)
                            {
                                Console.WriteLine(PurchaseError);
                                buyId = -1;
                            }
                            else if (buyId == 0)
                            {
                                Console.WriteLine(ExitShop);
                                
                            }
                            else
                            {
                                bool insuf = Convert.ToInt32(shop[buyId, 1]) > totalBits ? true : false;
                                if (insuf)
                                {
                                    Console.WriteLine(Ins);
                                }
                                else
                                {
                                    string[] auxArray = new string[inventory.GetLength(0) + 1];
                                    for (int i = 0; i < inventory.GetLength(0); i++)
                                    {
                                        auxArray[i] = inventory[i];
                                    }
                                    inventory = auxArray;
                                    inventory[inventory.GetLength(0) - 1] = shop[buyId, 0];
                                    totalBits -= Convert.ToInt32(shop[buyId, 1]);
                                    Console.WriteLine(PurchaseMsg, shop[buyId, 0], shop[buyId, 1]);
                                    Console.WriteLine(Bits, totalBits);
                                }
                            }
                        } while (buyId != 0);                

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
