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
            string firstName;
            string lastName;
            int age;
            double price;
            bool isStudent;


            Console.Write("Welcome to the Discount Calculator!");
            

            Console.Write("What is your first name?: ");
            firstName = Console.ReadLine();

            Console.Write("What is your last name?: ");
            lastName = Console.ReadLine();

            Console.Write("How old are you?: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("What is the price of the item you're interested in?: ");
            price = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false)");
            isStudent = bool.Parse(Console.ReadLine());
        }
    }
}
