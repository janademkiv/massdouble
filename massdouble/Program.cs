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

            //Random random = new Random();
            int[,] arr = new int[5, 6];
            int a = 0;
            for (int i = 0; i < arr.Length; i++) {
                a++;
                
            }Console.WriteLine(a);

            poisk(arr);
            //sumQuantity(arr);
            //inPrint(arr);
            //Console.WriteLine("Введите строку массива от 0 до 2");
            //int inX = int.Parse(Console.ReadLine());
            //Console.WriteLine("Сумма эллементов строки массива");
            //sumString(arr, inX);
            ////sumString(arr);
            ////sumk(arr);
            //Console.WriteLine("Элементы мас");
            //outPrint(arr);



            //Console.WriteLine("Эллементы массива");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        Console.WriteLine(arr[i, j]);
            //    }
            //}

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
                    //Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        ////13 возвращает сумму чисел указанной строки
        static int sumString(int[,] arr, int inX)
        {
            int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            for (int j = 0; j < 6; j++)
            {
                sum += arr[inX, j];
            }

            //}
            Console.WriteLine(sum);
            //int sum;
            //foreach (int f in sumString) { }
            return sum;
        }




        //14 возвращает кол-во нулевых, положит или отриц чисел в массиве
        static int sumQuantity(int[,] arr)
        {
            int a = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
            {
                if (j < 0)
                {
                    a++;
                    Console.WriteLine("Отрицательных " + a);
                    //return a;
                }
                if (j == 0)
                {
                    a++;
                    Console.WriteLine("Нулевых " + a);
                    //return a;
                }
                if (j > 0)
                {
                    a++;
                    Console.WriteLine("Положительных " + a);
                    //return a;
                }
            }
            }
            return a;
        }


        //static void poisk(int[,] a)
        //{
        //    byte p = 0;
        //    byte n = 0;
        //    byte o = 0;
        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            if (a[i, j] > 0) p++;
        //            else {
        //                if (a[i, j] < 0) o++; else n++;
        //            }
        //        }

        //    }
        //    Console.WriteLine();
        //    Console.WriteLine(" В массиве");
        //    Console.WriteLine();
        //    Console.WriteLine("Всего {0} чисел равных 0", n);
        //    Console.WriteLine("Всего {0} положительных чисел", p);
        //    Console.WriteLine("Всего {0} отрицательных чисел", o);
        //}


    }

}

