using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Sorting
{
    internal class Program
    {

        static void Main(string[] args)
        {
            WriteLine(ConsoleColor.Green, "## SORTING ##");

            var nums = GetInputArray();

            var alg = GetSortingAlgOption();
        }

        private static int GetSortingAlgOption()
        {
            int[] currentValidOptions = new int[] { 1, 2 };
            int input;
            do
            {
                WriteLine(ConsoleColor.White, "\n\n# Choose the desired sorting algorithm: ");
                WriteLine(ConsoleColor.White, "\n1 - Merge sort \n2 - Quick sort");
                Write(ConsoleColor.White, "\nR: ");
                input = Convert.ToInt32(Console.ReadLine().ToString());

                if (!currentValidOptions.Contains(input))
                {
                    WriteLine(ConsoleColor.Red, "Error: algorithm option not valid.");
                }
            } while (!currentValidOptions.Contains(input));

            return input;
        }

        private static int[] GetInputArray()
        {
            var nums = new List<int>();
            do
            {
                Write(ConsoleColor.White, "\n# Please insert the int32 array to be sorted(comma-separated): ");
                var input = Console.ReadLine().Split(',');

                foreach (var str in input)
                {

                    var success = Int32.TryParse(str, out var num);
                    if (success)
                    {
                        nums.Add(num);
                    }
                }

                if (!nums.Any())
                {
                    WriteLine(ConsoleColor.Red, "Error: input not valid.");
                }

            } while (!nums.Any());

            PrintInput(nums);

            return nums.ToArray();
        }

        private static void PrintInput(List<int> input)
        {
            Write(ConsoleColor.Gray, "Parsed input array: ");

            var sb = new StringBuilder("[");
            for (int i = 0; i < input.Count; i++)
            {
                sb.Append(input[i]);
                if (i != input.Count - 1)
                {
                    sb.Append(", ");
                }
                else
                {

                    sb.Append("]");
                }
            }

            Write(ConsoleColor.Gray, sb.ToString());
        }

        private static void WriteLine(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void Write(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}