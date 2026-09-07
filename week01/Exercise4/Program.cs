using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num = -1;

    while (num != 0)
    {
        Console.Write("Enter a list of numbers, (0 to quit):");
        string response = Console.ReadLine();
        int numb = int.Parse(response);
        

    if (numb != 0)
        {
            numbers.Add(numb);
        }

    int sum = 0;
    foreach (int number in numbers)
        {
            sum += numb;
        }

    Console.WriteLine($"The sum is {sum}");

    float average = ((float) sum) / numbers.Count;
    Console.WriteLine($"The average is {average}");

    int max = numbers [0];

    foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            Console.WriteLine($"The max is {max}");
        }

    }

        
    }        



        

}