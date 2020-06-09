using System;

namespace Store_opening_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;

            //We enter to the main while
            while (!stop)
            {
                //Display All Options 
                Console.WriteLine("Please, choose an option.\n");
                Console.WriteLine("1 - Display all days opened");
                Console.WriteLine("2 - Adds a new open day");
                Console.WriteLine("3 - Is my day open ?");
                Console.WriteLine("4 - Search for the next opening date ? \n");
                Console.WriteLine("q - Leave the program \n\n");

                // .... 

                string option = Console.ReadLine();


                //debug
                Console.WriteLine("you choose the option : " + option);

                switch (option)
                {
                    case "1":
                        DisplayDaysOpened();
                        break;

                    case "2":
                        NewOpeningDay();
                        break;

                    case "3":
                        SearchForOpenedDay();
                        break;

                    case "4":
                        SearchForNextOpeningDate();
                        break;

                    //If the option is 'q', we set the variable Stop to true
                    case "Q":
                    case "q":
                        Console.WriteLine("you have chosen to close the program.");
                        stop = true;
                        break;


                    default:
                        Console.WriteLine("your entry is incorrect, please try again...");
                        break;
                }

                Console.WriteLine("\n\n========================= \n\n\n");

                Console.ReadKey();

            }


            Console.ReadKey();
        }

        private static void SearchForNextOpeningDate()
        {

        }

        private static void SearchForOpenedDay()
        {

        }









        //Create a new openingDay.
        //To create it, we need its name and its time slot (opening time, closing time).
        private static void NewOpeningDay()
        {
            bool canStop = false;
            
            Console.WriteLine("You are here to create a new day that will be open for your store.");

            Console.WriteLine("First you have to choose the day :");
            Console.WriteLine(" ** Weekdays **");
            Console.WriteLine("1 - Monday");
            Console.WriteLine("2 - Tuesday");
            Console.WriteLine("3 - Wednesday");
            Console.WriteLine("4 - Thursday");
            Console.WriteLine("5 - Friday");
            Console.WriteLine(" ** Weekend ** ");
            Console.WriteLine("6 - Saturday");
            Console.WriteLine("7 - Sunday");

            string option = Console.ReadLine();


            //debug
            Console.WriteLine("you choose the option : " + option);

            switch (option)
            {
                case "1":
                    DisplayDaysOpened();
                    break;

                case "2":
                    NewOpeningDay();
                    break;

                case "3":
                    SearchForOpenedDay();
                    break;

                case "4":
                    SearchForNextOpeningDate();
                    break;

                //If the option is 'q', we set the variable Stop to true
                case "Q":
                case "q":
                    Console.WriteLine("you have chosen to close the program.");
                    stop = true;
                    break;


                default:
                    Console.WriteLine("your entry is incorrect, please try again...");
                    break;
            }

        }















        //Display all days opened
        private static void DisplayDaysOpened()
        {
            Console.WriteLine(" -- All Days --");
        }
    }
}
