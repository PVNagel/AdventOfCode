namespace AdventOfCode2022Day3
{
    internal class Program
    {
        // Only solution for part 1.
        static void Main(string[] args)
        {
            string[] sacks = File.ReadAllLines("Rucksack.txt");
            int total = 0;

            foreach(string sack in sacks)
            {
                string firstPart = GetFirst(sack);
                string secondPart = GetSecond(sack);
                char item = FindIntersection(firstPart, secondPart);
                int priority = GetPriority(item);
                total = total + priority;
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }

        public static string GetFirst(string sack)
        {
            return sack.Substring(0, sack.Length / 2);
        }

        public static string GetSecond(string sack)
        {
            return sack.Substring(sack.Length / 2, sack.Length / 2);
        }

        public static char FindIntersection(string first, string second)
        {
            return first.Intersect(second).First();
        }

        public static int GetPriority(char item)
        {
            if (char.IsUpper(item))
            {
                return item - 'A' + 27;
            }
            else
            {
                return item - 'a' + 1;
            }
        }
    }
}