using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massdouble
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {

            
            int[,] arr = new int[5, 6];
            //заполнение массива
            inPrint(arr);
            //int a = 0;
            //for (int i = 0; i < arr.Length; i++) {
            //    a++;
          
            //}Console.WriteLine(a);

            //вывод массива
            Console.WriteLine("Элементы мас");
            outPrint(arr);

            Console.WriteLine("Сумма эллементов строки массива. Введите от 0 до 4");
            int inX = int.Parse(Console.ReadLine());
            sumString(arr, inX);

            Console.WriteLine("Коллиество элементов");
            sumQuantity(arr);

            Console.ReadKey();
        }
        //11 заполнение масс
        static void inPrint(int[,] arr)
        {

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    arr[i, j] = random.Next(0, 10);
                }
            }
        }

        //12 вывод прямоуг
        static void outPrint(int[,] arr) {

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("{0,5}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        ////13 возвращает сумму чисел указанной строки
        static int sumString(int[,] arr, int inX)
        {
            int sum = 0;
            for (int j = 0; j < 6; j++)
            {
                sum += arr[inX, j];
            }
            Console.WriteLine(sum);
           
            return sum;
        }

       
        //14 возвращает кол-во нулевых, положит или отриц чисел в массиве
        static int sumQuantity(int[,] arr)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j < 0)
                    {
                        a++;
                    }
                    if (j == 0)
                    {
                        b++;
                    }
                    if (j > 0)
                    {
                        c++;
                       
                    }

                  
                }  
            }
            Console.WriteLine("Отрицательных " + a);
            Console.WriteLine("Нулевых " + b);
            Console.WriteLine("Положительных " + c);
            return a;
        }
    }

}

