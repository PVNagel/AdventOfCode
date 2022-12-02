using System.Reflection.Metadata.Ecma335;

namespace AdventOfCode2022Day1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Elves.txt");

            int sum = 0;
            int fattestElf = 0;
            int secondFattestElf = 0;
            int thirdFattestElf = 0;

            foreach (string line in lines)
            {
                if (line == string.Empty)
                {
                    if (sum > fattestElf)
                    {
                        thirdFattestElf = secondFattestElf;
                        secondFattestElf = fattestElf;
                        fattestElf = sum;
                    }

                    else if (sum > secondFattestElf)
                    {
                        thirdFattestElf = secondFattestElf;
                        secondFattestElf = sum;
                    }

                    else if (sum > thirdFattestElf)
                    {
                        thirdFattestElf = sum;
                    }

                    sum = 0;
                }
                else
                {
                    int calories = int.Parse(line);
                    sum = sum + calories;
                }
            }
            if (sum > fattestElf)
            {
                thirdFattestElf = secondFattestElf;
                secondFattestElf = fattestElf;
                fattestElf = sum;
            }

            else if (sum > secondFattestElf)
            {
                thirdFattestElf = secondFattestElf;
                secondFattestElf = sum;
            }

            else if (sum > thirdFattestElf)
            {
                thirdFattestElf = sum;
            }
            Console.WriteLine($"The fattest is: {fattestElf}");
            Console.WriteLine($"The second fattest is: {secondFattestElf}");
            Console.WriteLine($"The third fattest is: {thirdFattestElf}");
            Console.WriteLine("");
            Console.WriteLine($"Fat elves combined: {fattestElf + secondFattestElf + thirdFattestElf}");
            Console.ReadLine();
        }
    }
}
