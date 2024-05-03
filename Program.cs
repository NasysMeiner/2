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
            EnterNumber();//Ввод массива чисел

            int startDiv = 2;

            for (int i = 0; i < _capacity; i++)//Прохождение по всем элементам массива чисел
            {
                int currentDiv = startDiv;//Сброс текущего делителя

                for (int j = 0; j < arrNum[i]; j++)//Прохождение делителей до числа arrNum[i]
                {
                    if (arrNum[i] % currentDiv == 0)
                    {
                        if (CheckRepeat(currentDiv) || CheckNumberDiv(currentDiv))//Проверка на повтор и возможно ли деление всех элементов массива arrNum
                        {
                            currentDiv++;

                            continue;
                        }

                        arrDiv[i] = currentDiv;//Запись в массив

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

        static void EnterNumber()//Метод для генерации массива чисел
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

        static bool CheckRepeat(int value)//Метод для проверки на повторения
        {
            for(int i = 0; i < _capacity; i++)
            {
                if (value == arrDiv[i])
                    return true;
            }

            return false;
        }

        static bool CheckNumberDiv(int value)//Метод для проверки на делимость всех элементов в массиве
        {
            for (int h = 0; h < _capacity; h++)
                if (arrNum[h] % value != 0)
                    return true;

            return false;
        }
    }
}
