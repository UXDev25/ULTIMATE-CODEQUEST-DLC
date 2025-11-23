using System;
using System.IO;
using System.Runtime.InteropServices;
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

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);
            try
            {
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
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
