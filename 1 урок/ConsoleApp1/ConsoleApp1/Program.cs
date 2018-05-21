using System;
using l1;
using l2;
/*
 типы данных
 целые
 byte   0 - 255         1 byte
 short  -2^15 - 2^15    2 byte
 int    -2^31 - 2^31    4 byte
 long   -2^63 - 2^63    8 byte

дробные
float       10^38   4 byte
double      10^308  8 byte

символьные
char        
string


     */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            lesson_1 l1 = new lesson_1();
            lesson_2 l2 = new lesson_2();
            int choose = 0;
            Console.Write("Choose lesson:\r\n1 - 1-st lesson\r\n2 - 2nd lesson\r\n3 - Pow\r\n10 - Exit\r\nEnter here: ");
            choose = int.Parse(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    l1.fl1();
                    break;
                case 2:
                    l2.fl2();
                    break;
                case 3:
                    Console.WriteLine("pow = " + l2.Pow(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}