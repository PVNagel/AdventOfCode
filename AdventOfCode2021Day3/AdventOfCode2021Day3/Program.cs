namespace AdventOfCode2021Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> binaryNumbers;
            int numberOfBits;

            binaryNumbers = File.ReadAllLines(@"C:\Users\phili\Documents\Code\Exercises\AdventOfCode\AdventOfCode2021Day3\dataFile.txt").ToList();
            numberOfBits = binaryNumbers[0].Length;

            string[] gamma = new string[numberOfBits];
            string[] epsilon = new string[numberOfBits];

            for (int i = 0; i < binaryNumbers[0].Count(); i++)
            {
                gamma[i] = binaryNumbers.Where(x => x[i] == '1').Count() > (binaryNumbers.Count() / 2) ? "1" : "0";
            }

            for (int i = 0; i < binaryNumbers[0].Count(); i++)
            {
                epsilon[i] = binaryNumbers.Where(x => x[i] == '1').Count() < (binaryNumbers.Count() / 2) ? "1" : "0";
            }

            var gammaValue = ConvertToDecimal(string.Join("", gamma));
            var epsilonValue = ConvertToDecimal(string.Join("", epsilon));

            Console.WriteLine(gammaValue);
            Console.WriteLine(epsilonValue);
            Console.WriteLine(gammaValue * epsilonValue);
            Console.ReadLine();

        }
    }
}