using System;
using System.Collections.Generic;

namespace Store_opening_hours
{
    class Program
    {
        static private List<OpenDay> Days_list = new List<OpenDay>();

        static void Main(string[] args)
        {

            bool stop = false;
            //We enter to the main while
            while (!stop)
            {
                Console.Clear();

                //Display All Options 
                Console.WriteLine("Please, choose an option.\n");
                Console.WriteLine("1 - Display all days opened");
                Console.WriteLine("2 - Adds a new open day");
                Console.WriteLine("3 - Is my day open ?");
                Console.WriteLine("4 - Search for the next opening date ? \n");
                Console.WriteLine("q - Leave the program \n\n");

                string option = Console.ReadLine();


                //debug
                //Console.WriteLine("you choose the option : " + option);

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

                Console.ReadKey();

            }
        }

        private static void SearchForNextOpeningDate()
        {
        
        }

        private static void SearchForOpenedDay()
        {
            Console.WriteLine("Are you here to find out if the day you want is open?");
            Console.WriteLine("Exemple : Monday");


        }









        //Create a new openingDay.
        //To create it, we need its name and its time slot (opening time, closing time).
        private static void NewOpeningDay()
        {

            //Asks the user to enter the name of the desired day
            //Control if it's a real word
            bool canStop = false;
            string dayName = "";

            while (!canStop)
            {
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

                //lets choose the day name to the user
                switch (option)
                {
                    case "1":
                        dayName = "Monday";
                        break;

                    case "2":
                        dayName = "Tuesday";
                        break;

                    case "3":
                        dayName = "Wednesday";
                        break;

                    case "4":
                        dayName = "Thursday";
                        break;

                    case "5":
                        dayName = "Friday";
                        break;

                    case "6":
                        dayName = "Saturday";
                        break;

                    case "7":
                        dayName = "Sunday";
                        break;

                    default:
                        Console.WriteLine("your entry is incorrect, please try again...");
                        break;
                }

                //If dayName is empty, it's because the user wrote an incorrect entry. If not, we can leave the while
                if (!string.IsNullOrEmpty(dayName))
                {
                    //Console.WriteLine("You have chosen the day " + dayName);
                    canStop = true;
                }
            }



            //lets choose the opening day hour
            Console.WriteLine("\nPlease choose the opening time of the shop\n");
            Console.WriteLine("Example : 8h00");
            string openingHour = Console.ReadLine();

            //lets choose the closing day hour

            Console.WriteLine("\nPlease, choose the closing time of the shop\n");
            Console.WriteLine("Example : 17h15");

            string closingHour = Console.ReadLine();

            Console.WriteLine("You have chosen the day " + dayName);
            Console.WriteLine("Opening Hours : " + openingHour + " - " + closingHour);


            canStop = false;
            while (!canStop)
            {
                Console.WriteLine("Do you want save the entry ? (y) or cancel ? (n) ");

                string option = Console.ReadLine();

                //lets choose the day name to the user
                switch (option)
                {
                    //We save the entry
                    case "Y":
                    case "y":
                    case "yes":
                    case "Yes":
                        Days_list.Add(new OpenDay(dayName, openingHour, closingHour));
                        Console.WriteLine("The entry is saved !");
                        canStop = true;
                        break;

                    //we cancel
                    case "N":
                    case "n":
                    case "No":
                    case "no":
                        Console.WriteLine("Cancellation...");
                        canStop = true;
                        break;

                    default:
                        Console.WriteLine("your entry is incorrect, please try again...");
                        break;
                }
            }
        }














        //Display all days opened
        private static void DisplayDaysOpened()
        {
            //Read the list and simply display-it
            for (int i = 0; i < Days_list.Count; i++)
            {
                Console.WriteLine(Days_list[i].GetDayName + " : " + Days_list[i].GetOpeningHour + " - " + Days_list[i].GetClosingHour);
            }
        }
    }
}
