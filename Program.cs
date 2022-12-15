using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static int Sum(int number1, int number2)
        // - Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod
        {
            return number1 + number2;
        }
        //- Verilmiş ədədin kvadratını qaytaran metod
        static int kvadrat(int number1)
        {
            return number1 * number1;
        }
        //-  Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod
        static int Average(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3 + num4 / 4;
        }
        //- Verilmiş ədədin verilmiş qüvvətini tapan metod
        static int Quvvet(int num, int quvvet)
        {
            int result = 1;
            for (int i = 0; i < quvvet; i++)
            {
                result *= num;
            }
            return result;
        }
        // - Verilmiş ədədlər siyahısındaki ən böyük ədədin yerləşdiyi index-i qaytaran metod
        static int Biggest(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];

                }
            }
            return max;
        }
        //- Verilmiş yazılar siyahısındaki (string array) verilmiş yazının yerləşdiyi indexi qaytaran metod.Əgər verilmiş string array-de verilmiş string dəyər yoxdursa -1 qaytarsın

        static int FindIndex(string[] array, string name)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == name)
                    return i;
            }
            return -1;



        }
        // - Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından ibarət yeni bir array qaytaran metod.
        static int[] Positivereqemler(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    count++;

            }

            int j = 0;
            int[] positivereqemler = new int[count];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    positivereqemler[j] = numbers[i];
                    j++;
                }
            }

            return positivereqemler;
        }
        //- Verilmiş yazıda rəqəm olub olmadığını qaytaran metod
        static int Index(char[] arr, char letter)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == letter)
                    return i;
            }

            return -1;
        }

        static bool IsDigit(char letter)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            return Index(digits, letter) != -1;
        }


        static bool Digitvar(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (IsDigit(name[i]))
                {
                    return true;
                }
            }

            return false;
        }
        // Verilmis yazi siyahisinda nece yazida reqem oldugunu tapan metod

        static int Count(string[] names)
        {
            int count = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (Digitvar(names[i]))
                {
                    count++;
                }
            }

            return count;
        }
        //Verilmsi stringdeki ilk space olmayan charin indexini tapan metod

        static int Space(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                    return i;
            }
            return -1;
        }
        //Verilmis string deyerinden evvelinde bosluqlar olmayan yeni bir string duzeldib qaytaran metod

        static string Nospace(string name)
        {
            var startIndex = Space(name);
            string word1 = "";
            for (int i = startIndex; i < name.Length; i++)
            {
                word1 += name[i];
            }

            return word1;
        }
    }
}
