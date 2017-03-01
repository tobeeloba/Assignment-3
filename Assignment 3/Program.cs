using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to this Question and Answer Session " + name + "!");
            Console.WriteLine("You are going to be providing answers to 5 questions, ARE YOU READY?????");
            Console.WriteLine("Question 1: What is the capital of Nigeria?");
            string Ans1 = Console.ReadLine();
            Console.WriteLine("Your answer to Question 1 is: " + Ans1);
            Console.WriteLine("Get ready for Question 2.");
            Console.WriteLine("Question 2: What is the color of Nigeria's Flag?");
            string Ans2 = Console.ReadLine();
            Console.WriteLine("Your answer to Question 1 is: " + Ans2);
            Console.WriteLine("Get ready for Question 3.");
            Console.WriteLine("Question 3: What year did Nigeria gain her independence?");
            string Ans3 = Console.ReadLine();
            Console.WriteLine("Your answer to Question 3 is: " + Ans3);
            Console.WriteLine("Get ready for Question 4.");
            Console.WriteLine("Question 4: How many states does Nigeria have?");
            string Ans4 = Console.ReadLine();
            Console.WriteLine("Your answer to Question 4 is: " + Ans4);
            Console.WriteLine("Get ready for Question 5.");
            Console.WriteLine("Question 5: What year were you born?");
            string Ans5 = Console.ReadLine();
            Console.WriteLine(name + " You were born in year " + Ans5 + ".");
            Console.WriteLine("Thank you very mcuh for participating " + name + ".");
            Console.ReadLine();
        }
    }
}
