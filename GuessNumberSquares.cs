using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GuessNumberSquares
{
    class Program
    {
        public static int balance = 0;
        public static int boxNum = 1;
        public static int num = 0;
        public static int numprev = 0;
        public static Random r = new Random();
        public static bool isFirstTime = true;
        public static string selection = "";
        public static bool isFirstTime2 = true;
        public static int userChoice = 0;
        public static int progressNum = 0;
        public static int Num = 0;
        public static int remMistakeCounter = 2;
        static void FrameDrawer()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            // 1 box
            Console.SetCursorPosition(19, 2);
            Console.WriteLine("┌");
            Console.SetCursorPosition(19, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(19, 4);
            Console.WriteLine("└");
            Console.SetCursorPosition(20, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(21, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(22, 4);
            Console.WriteLine("┘");
            Console.SetCursorPosition(22, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(22, 2);
            Console.WriteLine("┐");
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("─");
            Console.SetCursorPosition(21, 2);
            Console.WriteLine("─");
            // 2 box
            Console.SetCursorPosition(28, 2);
            Console.WriteLine("┌");
            Console.SetCursorPosition(28, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(28, 4);
            Console.WriteLine("└");
            Console.SetCursorPosition(29, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(30, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(31, 4);
            Console.WriteLine("┘");
            Console.SetCursorPosition(31, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(31, 2);
            Console.WriteLine("┐");
            Console.SetCursorPosition(29, 2);
            Console.WriteLine("─");
            Console.SetCursorPosition(30, 2);
            Console.WriteLine("─");
            // 3 box
            Console.SetCursorPosition(37, 2);
            Console.WriteLine("┌");
            Console.SetCursorPosition(37, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(37, 4);
            Console.WriteLine("└");
            Console.SetCursorPosition(38, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(39, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(40, 4);
            Console.WriteLine("┘");
            Console.SetCursorPosition(40, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(40, 2);
            Console.WriteLine("┐");
            Console.SetCursorPosition(38, 2);
            Console.WriteLine("─");
            Console.SetCursorPosition(39, 2);
            Console.WriteLine("─");
            // 4 box
            Console.SetCursorPosition(46, 2);
            Console.WriteLine("┌");
            Console.SetCursorPosition(46, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(46, 4);
            Console.WriteLine("└");
            Console.SetCursorPosition(47, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(48, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(49, 4);
            Console.WriteLine("┘");
            Console.SetCursorPosition(49, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(49, 2);
            Console.WriteLine("┐");
            Console.SetCursorPosition(47, 2);
            Console.WriteLine("─");
            Console.SetCursorPosition(48, 2);
            Console.WriteLine("─");
            // 5 box
            Console.SetCursorPosition(55, 2);
            Console.WriteLine("┌");
            Console.SetCursorPosition(55, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(55, 4);
            Console.WriteLine("└");
            Console.SetCursorPosition(56, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(57, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(58, 4);
            Console.WriteLine("┘");
            Console.SetCursorPosition(58, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(58, 2);
            Console.WriteLine("┐");
            Console.SetCursorPosition(56, 2);
            Console.WriteLine("─");
            Console.SetCursorPosition(57, 2);
            Console.WriteLine("─");
            // 6 box
            Console.SetCursorPosition(64, 2);
            Console.WriteLine("┌");
            Console.SetCursorPosition(64, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(64, 4);
            Console.WriteLine("└");
            Console.SetCursorPosition(65, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(66, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(67, 4);
            Console.WriteLine("┘");
            Console.SetCursorPosition(67, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(67, 2);
            Console.WriteLine("┐");
            Console.SetCursorPosition(65, 2);
            Console.WriteLine("─");
            Console.SetCursorPosition(66, 2);
            Console.WriteLine("─");
            // 7 box
            Console.SetCursorPosition(73, 2);
            Console.WriteLine("┌");
            Console.SetCursorPosition(73, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(73, 4);
            Console.WriteLine("└");
            Console.SetCursorPosition(74, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(75, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(76, 4);
            Console.WriteLine("┘");
            Console.SetCursorPosition(76, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(76, 2);
            Console.WriteLine("┐");
            Console.SetCursorPosition(74, 2);
            Console.WriteLine("─");
            Console.SetCursorPosition(75, 2);
            Console.WriteLine("─");
            // 8 box
            Console.SetCursorPosition(82, 2);
            Console.WriteLine("┌");
            Console.SetCursorPosition(82, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(82, 4);
            Console.WriteLine("└");
            Console.SetCursorPosition(83, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(84, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(85, 4);
            Console.WriteLine("┘");
            Console.SetCursorPosition(85, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(85, 2);
            Console.WriteLine("┐");
            Console.SetCursorPosition(83, 2);
            Console.WriteLine("─");
            Console.SetCursorPosition(84, 2);
            Console.WriteLine("─");
            // 9 box
            Console.SetCursorPosition(91, 2);
            Console.WriteLine("┌");
            Console.SetCursorPosition(91, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(91, 4);
            Console.WriteLine("└");
            Console.SetCursorPosition(92, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(93, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(94, 4);
            Console.WriteLine("┘");
            Console.SetCursorPosition(94, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(94, 2);
            Console.WriteLine("┐");
            Console.SetCursorPosition(92, 2);
            Console.WriteLine("─");
            Console.SetCursorPosition(93, 2);
            Console.WriteLine("─");
            // 10 box
            Console.SetCursorPosition(100, 2);
            Console.WriteLine("┌");
            Console.SetCursorPosition(100, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(100, 4);
            Console.WriteLine("└");
            Console.SetCursorPosition(101, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(102, 4);
            Console.WriteLine("─");
            Console.SetCursorPosition(103, 4);
            Console.WriteLine("┘");
            Console.SetCursorPosition(103, 3);
            Console.WriteLine("│");
            Console.SetCursorPosition(103, 2);
            Console.WriteLine("┐");
            Console.SetCursorPosition(101, 2);
            Console.WriteLine("─");
            Console.SetCursorPosition(102, 2);
            Console.WriteLine("─");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Your balance is:");
            //Console.WriteLine("1000");

            Console.SetCursorPosition(0, 5);
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Algo()
        {


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Type H - for higher and L - for lower   Press Spacebar to start the game and to stop the rotation!");
            FrameDrawer();

        A:
            Console.SetCursorPosition(0, 15);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You have {0} remaining mistakes", remMistakeCounter);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("$ " + balance);
            Console.SetCursorPosition(0, 5);
            if (isFirstTime == false)
            {
                    if(progressNum == 1)
                    {
                        num = Num;
                    }
                    else
                    {
                        numprev = num;
                        num = Num;
                    }


            B:
                switch (userChoice)
                {
                        case 1:
                        if(num > numprev)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("Congratulations! Perfect guess!");
                            balance = balance + 10000;
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.SetCursorPosition(2, 3);
                            Console.WriteLine("$ " + balance);
                            Console.SetCursorPosition(0, 5);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.SetCursorPosition(0, 8);
                            Thread.Sleep(1500);
                            Console.WriteLine("                                                  ");
                            Console.SetCursorPosition(0, 5);
                            if(boxNum == 11)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Congratulations, You have complete the game!!!");
                                Console.WriteLine("Your final balance is: $ " + balance);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey(true);
                                Console.Clear();
                                Main();
                            }

                        }
                        else
                        {
                            boxNum--;
                            remMistakeCounter--;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine(" Try again! Wrong guess!");
                            Console.SetCursorPosition(0, 15);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You have {0} remaining mistakes", remMistakeCounter);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.SetCursorPosition(0, 8);
                            Thread.Sleep(2000);
                            Console.WriteLine("                                                  ");
                            Console.SetCursorPosition(0,5);
                            if (remMistakeCounter != 0)
                            {
                                Thread.Sleep(500);
                                switch (boxNum)
                                {
                                    case 1:
                                        Console.SetCursorPosition(20, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 2:
                                        Console.SetCursorPosition(29, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 3:
                                        Console.SetCursorPosition(38, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 4:
                                        Console.SetCursorPosition(47, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 5:
                                        Console.SetCursorPosition(56, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 6:
                                        Console.SetCursorPosition(65, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 7:
                                        Console.SetCursorPosition(74, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 8:
                                        Console.SetCursorPosition(83, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 9:
                                        Console.SetCursorPosition(92, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 10:
                                        Console.SetCursorPosition(101, 3);
                                        Console.WriteLine("  ");
                                        break;

                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your final balance is: $ " + balance);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Better luck next time!!!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey(true);
                                Console.Clear();
                                Main();
                            }
                        }
                        break;

                        case 2:
                        if (num < numprev)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine("Congratulations! Perfect guess!");
                            balance = balance + 10000;
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.SetCursorPosition(2, 3);
                            Console.WriteLine("$ " + balance);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.SetCursorPosition(0, 8);
                            Thread.Sleep(1500);
                            Console.WriteLine("                                                  ");
                            Console.SetCursorPosition(0, 5);
                            if (boxNum == 11)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Congratulations, You have complete the game!!! ");
                                Console.WriteLine("Your final balance is: $ " + balance);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey(true);
                                Console.Clear();
                                Main();
                            }
                        }
                        else
                        {
                            boxNum--;
                            remMistakeCounter--;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(0, 8);
                            Console.WriteLine(" Try again! Wrong guess!");
                            Console.SetCursorPosition(0, 15);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You have {0} remaining mistakes", remMistakeCounter);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.SetCursorPosition(0, 8);
                            Thread.Sleep(2000);
                            Console.WriteLine("                                                  ");
                            Console.SetCursorPosition(0, 5);
                            if (remMistakeCounter != 0)
                            {
                                Thread.Sleep(500);
                                switch (boxNum)
                                {
                                    case 1:
                                        Console.SetCursorPosition(20, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 2:
                                        Console.SetCursorPosition(29, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 3:
                                        Console.SetCursorPosition(38, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 4:
                                        Console.SetCursorPosition(47, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 5:
                                        Console.SetCursorPosition(56, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 6:
                                        Console.SetCursorPosition(65, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 7:
                                        Console.SetCursorPosition(74, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 8:
                                        Console.SetCursorPosition(83, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 9:
                                        Console.SetCursorPosition(92, 3);
                                        Console.WriteLine("  ");
                                        break;
                                    case 10:
                                        Console.SetCursorPosition(101, 3);
                                        Console.WriteLine("  ");
                                        break;

                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your final balance is: $ " + balance);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Better luck next time!!!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey(true);
                                Console.Clear();
                                Main();
                            }
                        }
                        break;
                }


              //  B:

                    if (isFirstTime2 == false)
                    {
                        for (int i = 0; i < selection.Length; i++)
                        {
                            Console.SetCursorPosition(i, 5);
                            Console.WriteLine(" ");
                        }

                    }

                    try
                    {


                        Console.SetCursorPosition(0, 5);
                        selection = Console.ReadLine();
                        Console.SetCursorPosition(0, 5);
                        Console.WriteLine(" ");
                        isFirstTime2 = false;

                    }
                    catch (Exception)
                    {
                        //goto B;
                    }

                    if(selection != "h" && selection != "l" && selection != "H" && selection != "L")
                    {
                        goto B;
                    }

                if(selection == "h" || selection == "H")
                {
                    Console.SetCursorPosition(0, 6);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("HIGHER");
                    userChoice = 1;
                }
                if(selection == "l" || selection == "L")
                {
                    Console.SetCursorPosition(0, 6);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("LOWER");
                    userChoice = 2;
                }


            }
            if (Console.KeyAvailable == false)
            {
 

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Num = r.Next(1, 51);

                    switch (boxNum)
                    {
                        case 1:
                            Console.SetCursorPosition(20, 3);
                            Console.WriteLine("  ");
                            Console.SetCursorPosition(20, 3);
                            Console.WriteLine(Num);
                            break;
                        case 2:
                            Console.SetCursorPosition(29, 3);
                            Console.WriteLine("  ");
                            Console.SetCursorPosition(29, 3);
                            Console.WriteLine(Num);
                            break;
                        case 3:
                            Console.SetCursorPosition(38, 3);
                            Console.WriteLine("  ");
                            Console.SetCursorPosition(38, 3);
                            Console.WriteLine(Num);
                            break;
                        case 4:
                            Console.SetCursorPosition(47, 3);
                            Console.WriteLine("  ");
                            Console.SetCursorPosition(47, 3);
                            Console.WriteLine(Num);
                            break;
                        case 5:
                            Console.SetCursorPosition(56, 3);
                            Console.WriteLine("  ");
                            Console.SetCursorPosition(56, 3);
                            Console.WriteLine(Num);
                            break;
                        case 6:
                            Console.SetCursorPosition(65, 3);
                            Console.WriteLine("  ");
                            Console.SetCursorPosition(65, 3);
                            Console.WriteLine(Num);
                            break;
                        case 7:
                            Console.SetCursorPosition(74, 3);
                            Console.WriteLine("  ");
                            Console.SetCursorPosition(74, 3);
                            Console.WriteLine(Num);
                            break;
                        case 8:
                            Console.SetCursorPosition(83, 3);
                            Console.WriteLine("  ");
                            Console.SetCursorPosition(83, 3);
                            Console.WriteLine(Num);
                            break;
                        case 9:
                            Console.SetCursorPosition(92, 3);
                            Console.WriteLine("  ");
                            Console.SetCursorPosition(92, 3);
                            Console.WriteLine(Num);
                            break;
                        case 10:
                            Console.SetCursorPosition(101, 3);
                            Console.WriteLine("  ");
                            Console.SetCursorPosition(101, 3);
                            Console.WriteLine(Num);
                            break;

                    }
                    Thread.Sleep(150);


                    if (Console.KeyAvailable == true && Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        boxNum = boxNum + 1;
                        if(isFirstTime == true)
                        {
                            balance = balance + 10000;
                        }
                        isFirstTime = false;
                        Console.SetCursorPosition(0, 6);
                        Console.WriteLine("      ");
                        progressNum++;
                        break;
                    }

                    
                    Console.ForegroundColor = ConsoleColor.Cyan;


                }
                goto A;
            }
            goto A;
        }

        static void Main()
        {
            //reseting vars
             balance = 0;
             boxNum = 1;
            num = 0;
            numprev = 0;
            isFirstTime = true;
            selection = "";
            isFirstTime2 = true;
            userChoice = 0;
            progressNum = 0;
            Num = 0;
            remMistakeCounter = 2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GUESS NUMBER SQUARES GAME!!!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Guess if the next number will be higher or lower than the previous!");
            Console.WriteLine("For this purpose use H - for higher and L - for lower");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("For every correct guess  $ 10 000 will be added to your balance");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Press any key to play!");
            Console.ReadKey(true);
            Console.Clear();
            Algo();
        }
    }
}
