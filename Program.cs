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

        //CHAPTER FOUR:
        const string ChFourTitle = "===== CHAPTER FOUR =====";
        const string ChFourBegin = "This is your inventory: ";
        const string NoInv = "- You have no items yet. -";

        string[] inventory = new string[0];
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

        int[,] coinMap = new int[6, 6];
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

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption4);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOption4);
            Console.WriteLine(MenuOption5);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);
            try
            {
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (op)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
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
                        Console.WriteLine();
                        break;

                    case 5:
                        //CHAPTER FIVE CODE:
                        Console.WriteLine(ChFiveTitle);
                        Console.WriteLine(ChFiveBegin);
                        Console.WriteLine(Bits);
                        Rows = 6;
                        Cols = 2;

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        //CHAPTER FOUR CODE:
                        Console.WriteLine(ChFourTitle);
                        Console.WriteLine(ChFourBegin);
                        bool hasItems = inventory.Length == 0 ? false : true;
                        if (!hasItems)
                        {
                            Console.WriteLine(NoInv);
                        //CHAPTER 3 CODE:
                        string[,] playerMap = { { "  ", " 1", " 2", " 3", " 4", " 5" }, { "-1", "➖", "➖", "➖", "➖", "➖" }, { "-2", "➖", "➖", "➖", "➖", "➖" }, { "-3", "➖", "➖", "➖", "➖", "➖" }, { "-4", "➖", "➖", "➖", "➖", "➖" }, { "-5", "➖", "➖", "➖", "➖", "➖" } };
                        Console.WriteLine(ChThreeTitle);
                        Console.WriteLine(ChThreeBegin, MaxAtt);
                        Rows = 6;
                        Cols = 6;
                        for (int i = 0; i < Rows; i++)
                        {
                            for (int j = 0; j < Cols; j++)
                            {
                                Console.Write($" | {shop[i, j],-15} | ");
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
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        do
                        {
                            validId = Int32.TryParse(Console.ReadLine(), out buyId);
                            if (!validId || buyId > 5)
                        else
                        {
                            foreach (string i in inventory)
                            while (validCords == false)
                            {
                                Console.WriteLine(PurchaseError);
                                buyId = -1;
                            }
                            else if (buyId == 0)
                            switch (coinMap[y, x])
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
                                Console.WriteLine($"- {i}");
                            }
                        }
                        Console.WriteLine(EndMine, totalBits);
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
