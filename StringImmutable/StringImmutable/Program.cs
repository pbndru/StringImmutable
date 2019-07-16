using System;

namespace StringImmutable
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, upper;
            Console.WriteLine("Enter Text: ");
            text = Console.ReadLine();

            // UNEXPECTED:  Does not convert text to uppercase as its immutable
            text.ToUpper();            
            System.Console.WriteLine($"Immutable string {text}", text);
            
            // EXPECTED:  convert text to uppercase
            upper = text.ToUpper();
            System.Console.WriteLine($"Mutable string {upper}", upper);

            Console.ReadKey();
        }
    }
}
