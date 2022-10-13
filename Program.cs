// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
            int choice = Menu();
            switch (choice)
            {
                case 1:
                    while (true)
                    {
                        decimal input1 = ReturnInput1();
                        decimal input2 = ReturnInput2();
                        string r=SumOfNumbers(input1, input2);
                        if (r=="Exit"||r=="exit"||r=="EXIT")
                        {
                            Console.Clear();
                            break;
                        }
                        if (r=="Yes" ||r=="Yes"||r=="YES")
                        {
                            continue;
                        }
                    }
                    break;
                case 2:
                while (true)
                    {
                        decimal input1 = ReturnInput1();
                        decimal input2 = ReturnInput2();
                        string r=SubtractionOfNumbers(input1, input2);
                        if (r=="Exit"||r=="exit"||r=="EXIT")
                        {
                            Console.Clear();
                            break;
                        }
                        if (r=="Yes" ||r=="Yes"||r=="YES")
                        {
                            continue;
                        }
                    }
                    break;
                    case 3:
                while (true)
                    {
                        decimal input1 = ReturnInput1();
                        decimal input2 = ReturnInput2();
                        string r=MultiplicationOfNumbers(input1, input2);
                        if (r=="Exit"||r=="exit"||r=="EXIT")
                        {
                            Console.Clear();
                            break;
                        }
                        if (r=="Yes" ||r=="Yes"||r=="YES")
                        {
                            continue;
                        }
                    }
                    break;
                    case 4:
                while (true)
                    {
                        decimal input1 = ReturnInput1();
                        decimal input2 = ReturnInput2();
                        string r=DivisionOfNumbers(input1, input2);
                        if (r=="Exit"||r=="exit"||r=="EXIT")
                        {
                            Console.Clear();
                            break;
                        }
                        if (r=="Yes" ||r=="Yes"||r=="YES")
                        {
                            continue;
                        }
                    }
                    break;
                    case 5:
                    Kitten();
                    break;
                    case 6:
                    break;
                    }
                    if (choice==6)
                    {
                    break;
                    }
            }
    
        }

        static void Kitten()
        {
            WriteLine(@"                                        /\  ");
            WriteLine(@"                                        ( )  ");
            WriteLine(@"                                         ) )  ");
            WriteLine(@"                                        / /");
            WriteLine(@"   ^               ^                    \ \   ");
            WriteLine(@"  /  \            /  \   _______________| |__                    ");
            WriteLine(@" / /\ \__________/ /\ \/                      \");
            WriteLine(@"|   ___        ___     |                      |");
            WriteLine(@"|  |_<_|      |_<_|    |                      |");
            WriteLine(@"|        \   /         |                      |  ");
            WriteLine(@"|       -- o --        |                     /       ");
            WriteLine(@"|         www          |____________________/        ");
            WriteLine(@" \____________________/      /__\      /__\");
            WriteLine(@"    /____\      /___\ ");

        }
        static decimal ReturnInput1()
        {
            while (true)
            {
                try
                {


                    ForegroundColor = ConsoleColor.White;
                    Write("What is gonna be your first number?: ");
                    decimal input1 = Convert.ToInt32(Console.ReadLine());
                    return input1;
                }
                catch
                {
                    Write("That is not a number. Try Again");
                }
            }
        }
            static decimal ReturnInput2()
            {
                while (true)
                {
                    try
                    {
                        ForegroundColor = ConsoleColor.White;
                        Write("What is gonna be your second number?: ");
                        decimal input2 = Convert.ToDecimal(ReadLine());
                        return input2;
                    }
                    catch
                    {
                        WriteLine(" That is not a number. Try again.");

                    }
                }

            }
            static string SumOfNumbers(decimal number1, decimal number2)
            {
                decimal result = number1 + number2;
                Write("Result: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                WriteLine(result);
                Console.ForegroundColor=ConsoleColor.White;
                while(true)
                {
                try{
                     ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("Do you wish to continue in 'ADDING'?");
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("Type 'Yes' if you want to continue in this section. ");
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Type 'Exit' if you want to go back to the menu.");
                ForegroundColor = ConsoleColor.White;
                string? r=ReadLine();
                if (r=="Exit" || r=="exit"||r=="EXIT"||r=="Yes"||r=="yes"||r=="Yes")
                return r;}
                catch
                {
                    WriteLine("Try Again.");
                }}
            }
            static string SubtractionOfNumbers(decimal number1, decimal number2)
            {
                decimal result = number1 - number2;
                Write("Result: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                WriteLine(result);
                Console.ForegroundColor=ConsoleColor.White;
                while(true)
                {
                try{
                     ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("Do you wish to continue in 'SUBTRACTING'?");
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("Type 'Yes' if you want to continue in this section. ");
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Type 'Exit' if you want to go back to the menu.");
                ForegroundColor = ConsoleColor.White;
                string? r=ReadLine();
                if (r=="Exit" || r=="exit"||r=="EXIT"||r=="Yes"||r=="yes"||r=="Yes")
                return r;
                }
                catch
                {
                    WriteLine("Try Again.");
                }}
            }
            static string MultiplicationOfNumbers(decimal number1, decimal number2)
            {
               decimal result = number1 * number2;
                Write("Result: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                WriteLine(result);
                Console.ForegroundColor=ConsoleColor.White;
                while(true)
                {
                try{
                     ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("Do you wish to continue in 'MULTIPLYING'?");
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("Type 'Yes' if you want to continue in this section. ");
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Type 'Exit' if you want to go back to the menu.");
                ForegroundColor = ConsoleColor.White;
                string? r=ReadLine();
                if (r=="Exit" || r=="exit"||r=="EXIT"||r=="Yes"||r=="yes"||r=="Yes")
                return r;
                }
                catch
                {
                    WriteLine("Try Again.");
                }}
            }
            static string DivisionOfNumbers(decimal number1, decimal number2)
            {
               decimal result = number1 / number2;
                Write("Result: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                WriteLine(result);
                Console.ForegroundColor=ConsoleColor.White;
                while(true)
                {
                try{
                     ForegroundColor = ConsoleColor.DarkGray;
                WriteLine("Do you wish to continue in 'DIVIDING'?");
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("Type 'Yes' if you want to continue in this section. ");
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Type 'Exit' if you want to go back to the menu.");
                ForegroundColor = ConsoleColor.White;
                string? r=ReadLine();
                if (r=="Exit" || r=="exit"||r=="EXIT"||r=="Yes"||r=="yes"||r=="Yes")
                return r;
                }
                catch
                {
                    WriteLine("Try Again.");
                }}
            }
            static int Menu()
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"OPERATIONS MENU", 20);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("1. ADD");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("2. SUBSTRACT");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("3. MULTIPLY");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("4. DIVIDE");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("5. CAT");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("6. Exit");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Press the number of the action you want to do: ");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        return choice;
                    }
                    catch
                    {
                        Clear();
                        WriteLine(" That is not in the options. Try again.");

                    }

                }
            }



        }
}




