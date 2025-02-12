namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            int tmpNum = 0;
            while (true)
            { 
                Console.Write("Введите число: ");
                UserInput = Console.ReadLine();
                if (UserInput == "")
                {
                    break;
                }
                int parseUInput = int.Parse(UserInput);
                if (tmpNum < parseUInput)
                {
                    tmpNum = parseUInput;
                }
            }
        }
    }
}

