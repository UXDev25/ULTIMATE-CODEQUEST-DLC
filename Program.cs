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

        //CHAPTER FOUR:
        const string ChFourTitle = "===== CHAPTER FOUR =====";
        const string ChFourBegin = "This is your inventory: ";
        const string NoInv = "- You have no items yet. -";

        string[] inventory = new string[0];

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption4);
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
