using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Store_opening_hours
{
    class Program
    {
        static private List<OpenDay> Days_list = new List<OpenDay>();

        static void Main(string[] args)
        {
            //Here we add some data for test our program
            Days_list.Add(new OpenDay("Monday", "8h00", "17h00"));
            Days_list.Add(new OpenDay("Thursday", "8h00", "12h00"));
            Days_list.Add(new OpenDay("Friday", "14h00", "17h00"));

            //We enter to the main while
            bool stop = false;
            while (!stop)
            {
                Console.Clear();

                //Display All Options 
                Console.WriteLine("Please, choose an option.\n");
                Console.WriteLine("1 - Display all opening days");
                Console.WriteLine("2 - Add a new opening day");
                Console.WriteLine("3 - Is that day an opening day ?");
                Console.WriteLine("4 - Search for the next opening date \n");
                Console.WriteLine("q - Leave the program \n\n");

                //Read the user's entry and put-it into a variable
                string option = Console.ReadLine();

                //Start the good option with the selected entry
                //if the user select something wrong (ex: 5, 6, "adse", etc), the 'default' case will say an error message.
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

                    //If the option is 'q', we set the variable Stop to true, so, we leave the main while and exit the program.
                    case "Q":
                    case "q":
                        Console.WriteLine("You have chosen to close the program.");
                        stop = true;
                        break;

                    default:
                        Console.WriteLine("Your entry is incorrect, please try again...");
                        break;
                }
                Console.ReadKey();
            }
        }

        /// <summary>
        /// This method is used to display some messages and ask to the user to choose a date.
        /// After That, it will use the method 'NextOpeningDate' and return  an error message if it's necessary.
        /// </summary>
        private static void SearchForNextOpeningDate()
        {
            Console.WriteLine("You are here to search for the next opening day");
            Console.WriteLine("Exemple : Thursday");

            string date = Console.ReadLine();

            //Lunch 'NextOpeningDate'. If there is no match, we send an error message
            if (!NextOpeningDate(date))
                Console.WriteLine("Sorry, we find nothing about this date.");

        }

        /// <summary>
        /// This method is used to search for the next opening date
        /// Read the list and search into-it if there is a match (if there, we display the next day)
        /// </summary>
        private static bool NextOpeningDate(string date)
        {
            //If we find something we could track back the information
            bool hasFindSomething = false;

            for (int i = 0; i < Days_list.Count; i++)
            {            
                //If there's a match, we display it
                if (Regex.IsMatch(date, Days_list[i].GetDayName))
                {
                    //Avoid stack overflow problem
                    if(i < Days_list.Count - 1)
                    {
                        Console.WriteLine(Days_list[i + 1].GetDayName + " : " + Days_list[i + 1].GetOpeningHour + " - " + Days_list[i + 1].GetClosingHour);
                        hasFindSomething = true;
                    }
                }
            }
            return hasFindSomething;
        }

        /// <summary>
        /// This method is used to display some messages and ask to the user to choose a date.
        /// After that, it will use the method 'IsOpenOn'ee
        /// </summary>
        private static void SearchForOpenedDay()
        {
            Console.WriteLine("Are you here to find out if the day you want is open ?");
            Console.WriteLine("Exemple : Monday");

            string date = Console.ReadLine();

            //Read the list and search into-it if there is a match
            //If there is no match, we send a message
            if(!IsOpenOn(date))
            {
                Console.WriteLine("Sorry, we find nothing about this date.");
            }
        }

        /// <summary>
        /// Check if the day in an opening day and if yes, display-it 
        /// Return false if there's no match
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private static bool IsOpenOn(string date)
        {
            //if we find something we could track back the information
            bool hasFindSomething = false;

            for (int i = 0; i < Days_list.Count; i++)
            {
                //If there's a match, we display it
                if (Regex.IsMatch(date, Days_list[i].GetDayName))
                {
                    Console.WriteLine(Days_list[i].GetDayName + " : " + Days_list[i].GetOpeningHour + " - " + Days_list[i].GetClosingHour);
                    hasFindSomething = true;
                }
            }
            return hasFindSomething;
        }

        /// <summary>
        /// Create a new openingDay.
        /// To create it, we need its name and its work time slot (opening time, closing time).
        /// Example : Monday, 8h00, 17h00.
        /// </summary>
        private static void NewOpeningDay()
        {
            //Asks the user to enter the name of the desired day
            //Control if it's a real day

            bool canStop = false;
            string dayName = "";

            while (!canStop)
            {
                Console.WriteLine("You are here to create a new day that will be open for your store.");

                Console.WriteLine("First you have to choose the day :");
                Console.WriteLine(" ** Weekdays ** ");
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
                //If the day it's wrong, we display an error message
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
                        Console.WriteLine("Your entry is incorrect, please try again...");
                        break;
                }

                //If dayName is empty, it's because the user wrote an incorrect entry and the switch case go to the default case.
                //If not, we can leave the while
                if (!string.IsNullOrEmpty(dayName))
                    canStop = true;

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
                        Console.WriteLine("Your entry is incorrect, please try again...");
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
