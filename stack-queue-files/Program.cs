using System;
using System.Collections;
using System.Collections.Generic;

namespace stack_queue_files
{
    internal class Program
    {
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
            string input = Console.ReadLine();

            // Split the input into parts (numbers and operators)
            string[] tokens = input.Split(' ');

            // Create a stack to store numbers
            Stack<double> stack = new Stack<double>();

            // Go through each part of the expression
            foreach (string token in tokens)
            {
                // Check if the current part is a number
                if (double.TryParse(token, out double number))//return true if the string is a number(result)
                {
                    // If it's a number, push it onto the stack
                    stack.Push(number);
                }
                else
                {
                    // If it's not a number, it must be an operator
                    // Pop two numbers from the stack
                    double second = stack.Pop();
                    double first = stack.Pop();

                    // Perform the operation based on the operator
                    double result = 0;
                    if (token == "+")
                    {
                        result = first + second;
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
