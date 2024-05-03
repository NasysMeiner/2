using System;
using System.Runtime.ConstrainedExecution;

namespace _2
{
    internal class Program
    {
        private static int _capacity;
        static int[] arrNum;
        static int[] arrDiv;

        static void Main(string[] args)
        {
            EnterNumber();

            int startDiv = 2;

            for (int i = 0; i < _capacity; i++)
            {
                int currentDiv = startDiv;

                for (int j = 0; j < arrNum[i]; j++)
                {
                    if (arrNum[i] % currentDiv == 0)
                    {
                        if (CheckRepeat(currentDiv) || CheckNumberDiv(currentDiv))
                        {
                            currentDiv++;

                            continue;
                        }

                        arrDiv[i] = currentDiv;

                        break;
                    }

                    currentDiv++;
                }
            }

            Console.Write("Исходный массив общих делителей: ");

            for(int i = 0; i < _capacity; i++)
            {
                Console.Write($"{arrDiv[i]} ");
            }
        }

        static void EnterNumber()
        {
            Console.Write("Введите кол-во чисел: ");

            _capacity = Convert.ToInt32(Console.ReadLine());
            arrNum = new int[_capacity];
            arrDiv = new int[_capacity];

            for (int i = 0; i < _capacity; i++)
            {
                Console.Write($"Введите число номер {i + 1}: ");

                arrNum[i] = Convert.ToInt32(Console.ReadLine());
            }        
        } 

        static bool CheckRepeat(int value)
        {
            for(int i = 0; i < _capacity; i++)
            {
                if (value == arrDiv[i])
                    return true;
            }

            return false;
        }

        static bool CheckNumberDiv(int value)
        {
            for (int h = 0; h < _capacity; h++)
                if (arrNum[h] % value != 0)
                    return true;

            return false;
        }
    }
}
