using System;
using System.Collections.Generic;
using System.Text;

/*
stack - быстрая паять
куча - медленная память
 */

//1-182-3
namespace l2
{
    class lesson_2
    {
        private void WriteArr(double[] arr)
        {
            Console.WriteLine("our arr is");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public void fl2()
        {
            Console.Clear();
            Console.Write("arr.Lenght is ");
            double[] arr1 = new double[int.Parse(Console.ReadLine())];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("arr[" + (i + 1) + "] = ");
                arr1[i] = double.Parse(Console.ReadLine());
                //arr1[i] = arr1.Length - i;
            }
            /*for (int i = 1; i < arr1.Length; i++)
                arr1[0] += arr1[i];*/
            Console.WriteLine();
            WriteArr(arr1);

            //sort
            double temp = 0;
            for(int i = arr1.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr1[j] > arr1[j + 1])
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
                WriteArr(arr1);
            }


            WriteArr(arr1);

            Console.Read();
        }

        public double Pow(double a, double b)
        {
            double r = 1;
            for (int i = 0; i < b; i++)
                r *= a;
            return r;
        }

        public float[] ret_arr(float[] arr)
        {
            return arr;
        }
    }
}
