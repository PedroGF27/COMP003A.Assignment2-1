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

            Console.WriteLine("******************************************************"); // Asterick line
            Console.Write("Welcome to the Discount Calculator!"); // Opening greeting
            Console.WriteLine("\n******************************************************"); // Asterick line

            Console.Write("\nWhat is your first name?: "); // Asks user to add their first name
            firstName = Console.ReadLine(); // Stores user first name

            Console.Write("What is your last name?: "); // Asks user to add their last name
            lastName = Console.ReadLine(); // Stores user last name

            Console.Write("How old are you?: "); // Asks user's age
            age = int.Parse(Console.ReadLine()); // Stores user's age

            Console.Write("What is the price of the item you're interested in?: "); // Asks for price of product
            price = double.Parse(Console.ReadLine()); // stores price of item

            Console.Write("Are you a student? (true/false): "); // Whether you are a student or not
            isStudent = bool.Parse(Console.ReadLine()); // Stores whether or not you're a student

            int futureAge = age + 5; // Calculate user's age in 5 years
            bool Adult = age >= 18; // Determines whether user is an adult
            double studentDiscount = price * .9; // Calculate Student Discount
            double seniorDiscount = price * .8; // Calculate Senior Discount

            Console.WriteLine("\n******************************************************"); // Asterick line
            Console.WriteLine($"\nHello, {firstName} {lastName}!"); // Greeting user
            Console.WriteLine($"Your current age is {age}."); // Shows user current
            Console.WriteLine($"In 5 years, you will be {futureAge}"); // Shows user's age in 5 years
            Console.WriteLine($"The original price of the item is ${price}"); // Shows original price of item
            Console.WriteLine($"As a Student, your discounted price is ${studentDiscount}"); // Shows the price after student dicsount
            Console.WriteLine($"As a Senior Citizen, your discounted price would be ${seniorDiscount}"); // Shows the price after senior discount
            Console.WriteLine("\n******************************************************"); // Asterick line
        }
    }
}
