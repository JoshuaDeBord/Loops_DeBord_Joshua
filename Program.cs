using System;

namespace Loops_DeBord_Joshua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Why do you want to make games?");
            string answer1 = Console.ReadLine();
            Console.WriteLine($"The sentence, \"{answer1}\" has {CountNumberOfSpaces(answer1)} spaces in it.");

            Console.WriteLine("Please enter a whole number!");
            string answer2 = Console.ReadLine();
            Console.WriteLine($"The sum of the individual digits of {answer2} is {SumOfDigits(answer2)}!");
        }
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character in sentence)
            {
                if(character == ' ')
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces;
        }

        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach(char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
            
        }
    }
}
