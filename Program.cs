using System;
using System.Runtime.InteropServices;

public class Program
{
    static void Main()
    {
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
