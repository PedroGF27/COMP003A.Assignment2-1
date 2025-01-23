/*
Author: Pedro Garcia
Course: COMP003A
Faculty: Jonathan Cruz
Purpose: COMP-003A - Lecture Actitvity
*/
namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName; // Variable to store user first name
            string lastName; // Variable to store user last name
            int age; // Variable to store user's age
            double price; // Variable to store product price
            bool isStudent; // Variable to store whether user is a student


            Console.Write("Welcome to the Discount Calculator!"); 
            

            Console.Write("What is your first name?: "); // Asks user to add their first name
            firstName = Console.ReadLine();

            Console.Write("What is your last name?: "); // Asks user to add their last name
            lastName = Console.ReadLine();

            Console.Write("How old are you?: "); // Asks user's age
            age = int.Parse(Console.ReadLine());

            Console.Write("What is the price of the item you're interested in?: "); // Asks for price of product
            price = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false)"); // Whether you are a student or not
            isStudent = bool.Parse(Console.ReadLine());

            int futureAge = age + 5;

        }
    }
}
