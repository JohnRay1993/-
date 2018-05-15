using System;
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
            ConsoleKeyInfo c, cY = new ConsoleKeyInfo('y', ConsoleKey.Y, false, false, false);

            do
            {
                Console.Clear();
                string l = Console.ReadLine();
                string[] parts = l.Split(' ');
                float a = 0, b = 0, result = 0;
                char oper = '0';
                if ((parts[0][0] >= '0' && parts[0][0] <= '9') || parts[0][0] == '-') a = float.Parse(parts[0]);
                if (parts[1][0] == '+' || parts[1][0] == '-' || parts[1][0] == '*' || parts[1][0] == '/' || parts[1][0] == '%')
                    oper = parts[1][0];
                if ((parts[2][0] >= '0' && parts[2][0] <= '9') || parts[2][0] == '-') b = float.Parse(parts[2]);
                if (oper != '0')
                switch (oper)
                {
                    case '+':
                        {
                            result = a + b;
                            break;
                        }
                    case '-':
                        {
                            result = a - b;
                            break;
                        }
                    case '*':
                        {
                            result = a * b;
                            break;
                        }
                    case '/':
                        {
                            result = a / b;
                            break;
                        }
                    case '%':
                        {
                            result = a % b;
                            break;
                        }
                    default: break;
                }
                Console.Clear();
                Console.WriteLine(a + " " + oper + " " + b + " = " + result);

                Console.Write("Repeate? (y == yes; n == no)");
                c = Console.ReadKey();
                Console.WriteLine("\r\n(.)(.)\r\n");
            } while (c == cY);

            /*
            float result = 0, fTemp = 0;
            string sTemp, oper = "";
            do
            {
                sTemp = Console.ReadLine();
                if (sTemp[0] >= '0' && sTemp[0] <= '9')
                {
                    //number
                    if (result == 0)
                    {
                        result = float.Parse(sTemp);
                    }
                    else
                    {
                        fTemp = float.Parse(sTemp);
                    }

                }
                else
                {
                    //oper
                    if (sTemp[0] != 'e')
                        oper = sTemp;
                    else
                        c = cY;//exit
                }
                if (result != 0 && fTemp != 0 && oper != "")
                {
                    switch (oper[0])
                    {
                        case '+':
                            {
                                result += fTemp;
                                break;
                            }
                        case '-':
                            {
                                result -= fTemp;
                                break;
                            }
                        case '*':
                            {
                                result *= fTemp;
                                break;
                            }
                        case '/':
                            {
                                if (fTemp != 0)
                                {
                                    result /= fTemp;
                                }
                                else
                                {
                                    Console.WriteLine("Ах ты, негодник, захотел поделить на 0? фу таким быть!");
                                }
                                break;
                            }
                        case '%':
                            {
                                if (fTemp != 0)
                                {
                                    result %= fTemp;
                                }
                                else
                                {
                                    Console.WriteLine("Ах ты, негодник, захотел поделить на 0? фу таким быть!");
                                }
                                break;
                            }
                        default: break;
                    }
                    fTemp = 0;
                    oper = "";
                    Console.WriteLine("  = " + result);
                }
            } while (c != cY);
            */
        }
    }
}