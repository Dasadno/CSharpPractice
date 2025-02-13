namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] revArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 0)
                {
                    revArr[i] = arr[arr.Length - i - 1];
                }
                else
                {
                    revArr[i] = arr[arr.Length - 1];
                }
            }
            foreach (int el in revArr)
            {
                Console.Write($"{el} ");
            }
        }
    }
}

