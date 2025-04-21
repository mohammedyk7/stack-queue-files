using System;
using System.Collections;
using System.Collections.Generic;

namespace stack_queue_files
{
    internal class Program
    {
        static void Main(string[] args)
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
    }

    
}
