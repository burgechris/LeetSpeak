using System;
using Leetspeak;

namespace LeepProgram
{
    public class LeepProgram
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a word or phrase and I will convert it to leetspeak.");
            string input = Console.ReadLine();
            Converter newConverter = new Converter(input);
            Console.WriteLine(newConverter.Input);
        }
    }
}