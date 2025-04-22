using System;
using System.Collections;
using System.Collections.Generic;

namespace stack_queue_files
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Provide options to the user
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Reverse a string");
            Console.WriteLine("2. Evaluate a postfix expression");
            Console.WriteLine("Browser History Navigation ");
            Console.WriteLine("XML/HTML Tag Validator");
            Console.WriteLine("Rotate Queue Elements by K");
            Console.WriteLine("Sort a Queue Using Only Queue Operations ");
            Console.WriteLine("Sliding Window Maximum Using Queue");
            Console.Write("Write Names to File ");
            Console.WriteLine("Search for a Word in a File");
            Console.WriteLine("Count Words in a File");
            Console.WriteLine("Count Lines, Words, and Characters");
            Console.WriteLine("Word Frequency Counter");
            Console.WriteLine("Filter and Save Specific Lines");
            Console.WriteLine("Split and Merge Files");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Reverse();
            }
            else if (choice == "2")
            {
                EvaluatePostfix();
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting program.");
            }
        }

        public static void Reverse()
        {
            // Prompt the user to enter a string
            Console.Write("Enter a string: ");
            string? characters = Console.ReadLine();

            // Initialize a stack to store characters
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            // Push each character of the input string onto the stack
            foreach (char c in characters)
                stack.Push(c);

            // Initialize an empty string to store the reversed version
            string reversed = string.Empty;
            string word = string.Empty;

            // Pop characters from the stack and append them to the reversed string
            while (stack.Count > 0)
                reversed += stack.Pop(); // This reverses the string by LIFO (Last In, First Out) order its lioke word--
            while (stack.Count > 0)
                word += queue.Dequeue(); // This reverses the string by fifo its like word++ 

            // Display the reversed string
            Console.WriteLine("Reversed: " + reversed);

            // Check if the reversed string matches the original input
            if (reversed != word)
                Console.WriteLine("It's a palindrome!"); // If they match, it's a palindrome
            else
                Console.WriteLine("Not a palindrome."); // Otherwise, it's not a palindrome

            // Wait for a key press before closing the console
            Console.ReadKey();
        }

        public static void EvaluatePostfix()
        {
            // Ask the user to enter a postfix expression
            Console.Write("Enter a postfix expression (e.g., '5 3 + 8 *'): ");
            string? input = Console.ReadLine();

            // Split the input into parts (numbers and operators)
            string[] tokens = input.Split(' ');//tokens are both numbers and operators so we split them by space

            // Create a stack to store numbers
            Stack<double> stack = new Stack<double>();

            // Go through each part of the expression
            foreach (string token in tokens)
            {
                // Check if the current part is a number
                if (double.TryParse(token, out double number))//return true if the string is a number(result)+ check the token is a number if yes push 
                {
                    // If it's a number, push it onto the stack
                    stack.Push(number);
                } // or bool success = double.TryParse(token, out double number);

                else
                {
                    // If it's not a number, it must be an operator
                    // Pop two numbers from the stack
                    if (stack.Count < 2) //two numbers are needed to perform an operation
                    {
                        Console.WriteLine("Error: Invalid postfix expression.");
                        return;
                    }
                   
                    double second = stack.Pop();
                    double first = stack.Pop();

                    // Perform the operation based on the operator
                    double result = 0;
                    if (token == "+")
                    {
                        result = first + second;// add the first and second numbers 5 3 +
                    }
                    else if (token == "-")
                    {
                        result = first - second;
                    }
                    else if (token == "*")
                    {
                        result = first * second;
                    }
                    else if (token == "/")
                    {
                        result = first / second;
                    }
                    else
                    {
                        // If the operator is not recognized, show an error
                        Console.WriteLine("Error: Unknown operator '" + token + "'");
                        return;
                    }

                    // Push the result back onto the stack
                    stack.Push(result);
                }
            }

            // The final result is the only number left in the stack
            double finalResult = stack.Pop();
            Console.WriteLine("Result: " + finalResult);
        }
    }


}
