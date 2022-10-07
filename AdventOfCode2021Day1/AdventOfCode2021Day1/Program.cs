namespace AdventOfCode2021Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 1;
            int count = 0;

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\phili\Documents\Code\Exercises\AdventOfCode2021Day1\dataFile.txt");
            int[] data = new int[lines.Length];

            int localCount = 0;
            int tempNumber;
            foreach (string line in lines)
            {
                int.TryParse(line, out tempNumber);
                data[localCount] = tempNumber;
                localCount++;
            }

            for (int i = 0; i < data.Length - 1; i++)
            {
                if (data[j] > data[i])
                {
                    count++;
                }
                j++;
            }

            int result = 0;
            for (int i = 3; i < data.Length; i++)
            {
                if (data[i] + data[i - 1] + data[i - 2] > data[i - 1] + data[i - 2] + data[i - 3])
                {
                    result++;
                }
            }
            Console.WriteLine("The amount of times the submarine's depth increases: " + count);
            Console.WriteLine("The version with less noise: " + result);
            Console.ReadLine();
        }
    }
}