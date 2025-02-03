using System;

namespace HomeWorkDynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSumNumbers = "sum";
            const string CommandExit = "exit";

            int sumNumbers = 0;
            int[] numberesArray = new int[0];

            string inputUser;
            bool isOpen = true;

            while (isOpen)
            {
                Console.WriteLine("получение суммы всех чисел массива введите - sum");
                Console.WriteLine("длы выхода введите - exit");
                Console.WriteLine("-------------------------------------------");
                Console.Write("Введите ваше число: ");

                inputUser = Console.ReadLine();

                if (inputUser == CommandSumNumbers || inputUser == CommandExit)
                {
                    switch (inputUser)
                    {
                        case CommandSumNumbers:
                            for (int i = 0; i < numberesArray.Length; i++)
                            {
                                sumNumbers += numberesArray[i];
                            }
                            Console.WriteLine("\nСумма всех чисел: " + sumNumbers + "\n\n");
                            break;

                        case CommandExit:
                            isOpen = false;
                            break;

                        default:
                            Console.WriteLine("\nневерная комманда\n");
                            break;
                    }
                }
                else
                {
                    int[] tempNumbers = new int[numberesArray.Length + 1];

                    for (int i = 0; i < tempNumbers.Length; i++)
                    {
                        tempNumbers[i] = Convert.ToInt32(inputUser);
                    }

                    for (int i = 0; i < numberesArray.Length; i++)
                    {
                        tempNumbers[i] = numberesArray[i];
                    }

                    numberesArray = tempNumbers;

                    Console.WriteLine("\nВаш массив: ");

                    for (int i = 0; i < numberesArray.Length; i++)
                    {
                        Console.Write(numberesArray[i] + " ");
                    }

                    Console.WriteLine("\n");
                }
            }
        }
    }
}
