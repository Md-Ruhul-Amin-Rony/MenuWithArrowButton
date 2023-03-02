//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            int choice = 0;
//            ConsoleColor selectedColor = ConsoleColor.DarkCyan;
//            ConsoleColor defaultColor = ConsoleColor.White;
//            ConsoleColor hiddenColor = ConsoleColor.Black;
//            bool showAllOptions = true;

//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("Main Menu");

//                Console.ForegroundColor = choice == 1 ? selectedColor : showAllOptions ? defaultColor : hiddenColor;
//                Console.WriteLine("1. Option 1");

//                Console.ForegroundColor = choice == 2 ? selectedColor : showAllOptions ? defaultColor : hiddenColor;
//                Console.WriteLine("2. Option 2");

//                Console.ForegroundColor = choice == 3 ? selectedColor : showAllOptions ? defaultColor : hiddenColor;
//                Console.WriteLine("3. Option 3");

//                Console.ForegroundColor = choice == 4 ? selectedColor : showAllOptions ? defaultColor : hiddenColor;
//                Console.WriteLine("4. Exit");

//                Console.ResetColor();

//                Console.Write("Select an option using arrow keys and press Enter: ");

//                // Read user input
//                ConsoleKeyInfo key = Console.ReadKey(true);

//                // Process user input
//                switch (key.Key)
//                {
//                    case ConsoleKey.UpArrow:
//                        if (choice > 1)
//                            choice--;
//                        break;
//                    case ConsoleKey.DownArrow:
//                        if (choice == 4)
//                            choice = 1;
//                        else if (choice < 4)
//                            choice++;
//                        break;
//                    case ConsoleKey.Enter:
//                        if (choice != 0)
//                            break;
//                        else
//                            continue;
//                    case ConsoleKey.Tab:
//                        showAllOptions = !showAllOptions;
//                        break;
//                    default:
//                        continue;
//                }
//            }

//            Console.WriteLine("You selected option {0}.", choice);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("An error occurred: " + ex.Message);
//        }
//    }
//}


//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            int choice = 0;
//            ConsoleColor selectedColor = ConsoleColor.Green;
//            ConsoleColor defaultColor = ConsoleColor.White;
//            ConsoleColor hiddenColor = ConsoleColor.Black;
//            bool hideOtherOptions = false;

//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("Main Menu");

//                Console.ForegroundColor = choice == 1 ? selectedColor : (choice != 0 && hideOtherOptions) ? hiddenColor : defaultColor;
//                Console.WriteLine("1. Option 1");

//                Console.ForegroundColor = choice == 2 ? selectedColor : (choice != 0 && hideOtherOptions) ? hiddenColor : defaultColor;
//                Console.WriteLine("2. Option 2");

//                Console.ForegroundColor = choice == 3 ? selectedColor : (choice != 0 && hideOtherOptions) ? hiddenColor : defaultColor;
//                Console.WriteLine("3. Option 3");

//                Console.ForegroundColor = choice == 4 ? selectedColor : defaultColor;
//                Console.WriteLine("4. Exit");

//                Console.ResetColor();

//                Console.WriteLine("Select an option using arrow keys and press Enter: ");

//                // Read user input
//                ConsoleKeyInfo key = Console.ReadKey(true);

//                // Process user input
//                switch (key.Key)
//                {
//                    case ConsoleKey.UpArrow:
//                        if (choice > 1)
//                        {
//                            choice--;
//                            hideOtherOptions = true;
//                        }
//                        else if (choice == 1)
//                        {
//                            choice = 4;
//                            hideOtherOptions = true;
//                        }
//                        break;
//                    case ConsoleKey.DownArrow:
//                        if (choice == 4)
//                        {
//                            choice = 1;
//                            hideOtherOptions = true;
//                        }
//                        else if (choice < 4)
//                        {
//                            choice++;
//                            hideOtherOptions = true;
//                        }
//                        break;
//                    case ConsoleKey.Enter:
//                        if (choice == 1)
//                        {
//                            Option1();

//                        }
//                        else if (choice == 2)
//                            Option2();
//                        else if (choice == 3)

//                            Option3();
//                        else if (choice == 4)
//                            Environment.Exit(0);
//                        else
//                            continue;






//                       // if (choice != 0)
//                            break;
//                        //else
//                        //    continue;
//                    default:
//                        continue;
//                }
//            }

//            Console.WriteLine("You selected option {0}.", choice);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("An error occurred: " + ex.Message);
//        }
//    }
//    public static void Option1()
//    {
//        Console.WriteLine("You have selected option 1:");
//        Console.WriteLine("Performing some action...");
//    }
//    static void Option2()
//    {
//        Console.WriteLine("You have selected option 2:");
//    }
//    static void Option3()
//    {
//        Console.WriteLine("You have selected option 3:");
//    }
//}



using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int choice = 0;
            ConsoleColor selectedColor = ConsoleColor.Green;
            ConsoleColor defaultColor = ConsoleColor.White;
            ConsoleColor hiddenColor = ConsoleColor.Black;
            bool hideOtherOptions = false;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Main Menu");

                Console.ForegroundColor = choice == 1 ? selectedColor : (choice != 0 && hideOtherOptions) ? hiddenColor : defaultColor;
                Console.WriteLine("1. Option 1");

                Console.ForegroundColor = choice == 2 ? selectedColor : (choice != 0 && hideOtherOptions) ? hiddenColor : defaultColor;
                Console.WriteLine("2. Option 2");

                Console.ForegroundColor = choice == 3 ? selectedColor : (choice != 0 && hideOtherOptions) ? hiddenColor : defaultColor;
                Console.WriteLine("3. Option 3");

                Console.ForegroundColor = choice == 4 ? selectedColor : defaultColor;
                Console.WriteLine("4. Exit");

                Console.ResetColor();

                Console.WriteLine("Select an option using arrow keys and press Enter: ");

                // Read user input
                ConsoleKeyInfo key = Console.ReadKey(true);

                // Process user input
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (choice > 1)
                        {
                            choice--;
                            hideOtherOptions = true;
                        }
                        else if (choice == 1)
                        {
                            choice = 4;
                            hideOtherOptions = true;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (choice == 4)
                        {
                            choice = 1;
                            hideOtherOptions = true;
                        }
                        else if (choice < 4)
                        {
                            choice++;
                            hideOtherOptions = true;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (choice == 1)
                        {
                            Option1();
                            continue;
                        }
                        else if (choice == 2)
                            Option2();
                        else if (choice == 3)
                            Option3();
                        else if (choice == 4)
                            Environment.Exit(0);
                        else
                            continue;
                        break;
                    default:
                        continue;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static void Option1()
    {
        Console.WriteLine("You selected option 1.");
        Console.WriteLine("Please tryck enter to continue:");
        Console.ReadLine();
        
        // Add code to run when option 1 is selected
    }

    static void Option2()
    {
        Console.WriteLine("You selected option 2.");
        Console.ReadLine();
        // Add code to run when option 2 is selected
    }

    static void Option3()
    {
        Console.WriteLine("You selected option 3.");
        Console.ReadLine();
        // Add code to run when option 3 is selected
    }
}
