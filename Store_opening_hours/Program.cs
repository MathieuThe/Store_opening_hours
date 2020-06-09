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

            }

          
            Console.ReadKey();
        }

        private static void SearchForNextOpeningDate()
        {

        }

        private static void SearchForOpenedDay()
        {

        }

        private static void NewOpeningDay()
        {

        }

        //Display all days opened
        private static void DisplayDaysOpened()
        {
            Console.WriteLine(" -- All Days --");
        }
    }
}
