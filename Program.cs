using System;
internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите 1 - если хотите сложить, 2 - вычесть, exit - выйти");
            string userInput = Console.ReadLine();

            if (userInput == "exit")
            {
                break;
            }

            if (userInput == "1")
            {
                Console.WriteLine("Введите числа, которые хотите сложить: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                int result = firstNumber + secondNumber;
                Console.WriteLine("Ответ: " + result);
            }

            if (userInput == "2")
            {
                Console.WriteLine("Введите числа, которые хотите вычесть: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                int result = firstNumber - secondNumber;
                Console.WriteLine("Ответ: " + result);
            }
        }
    }
}