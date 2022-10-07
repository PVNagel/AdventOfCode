namespace AdventOfCode2021Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horizontal = 0;
            int depth = 0;
            int x = 0;
            int aim = 0;

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\phili\Documents\Code\Exercises\AdventOfCode2021Day2\dataFile.txt");

            char seperator = ' ';

            string[] command = new string[lines.Length];
            int[] value = new int[lines.Length];


            for (int i = 0; i < lines.Length; i++)
            {
                string temp = lines[i];
                string[] tempArray = temp.Split(seperator);
                command[i] = tempArray[0];
                value[i] = int.Parse(tempArray[1]);
            }

            for (int i = 0; i < lines.Length; i++)
            {
                if (command[i] == "forward")
                {
                    horizontal = horizontal + value[i];
                    if (aim != 0)
                    {
                        depth = depth + (value[i] * aim);
                    }
                }

                else if (command[i] == "up")
                {
                    aim = aim - value[i];
                }

                else if (command[i] == "down")
                {
                    aim = aim + value[i];
                }
            }
            Console.WriteLine("horizontal position: " + horizontal + " Depth: " + depth);
            Console.WriteLine("Position: " + (horizontal * depth));
            Console.WriteLine("This Program includes part 2 of day 2.");
            Console.ReadLine();
        }
    }
}