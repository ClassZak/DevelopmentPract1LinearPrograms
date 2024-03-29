﻿namespace Tasks
{
    public class FirstPart
    {
        class SpecialFunctions 
        {
            static public ulong Factorial(int n)
            {
                if (n < 0)
                    throw new ArgumentException("Введено отроцательное число для нахождения факториала!");
                if (n == 0) return 1;
                if (n == 1) return 1;
                if (n == 2) return 2;

                return (Factorial(n - 1)) * (ulong)n;
            }
            static public double DegreesToRadians(double radians)
            {
                return radians * Math.PI / 180;
            }
        }
        
        static public void Task1_1()
        {
            try
            {
                double x; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                result = Math.Sqrt(Math.Pow(x, 8) + Math.Pow(8, x)) - 1 / Math.Sin(SpecialFunctions.DegreesToRadians(5 / x));

                Console.WriteLine("Значение формулы 1:");
                Console.WriteLine("Для x = {0:f2}", x);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_2()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = (1 - Math.Pow(Math.Tan(SpecialFunctions.DegreesToRadians(x)), 1 / Math.Tan(SpecialFunctions.DegreesToRadians(x)))) + Math.Cos(SpecialFunctions.DegreesToRadians(x - y));

                Console.WriteLine("Значение формулы 2:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_3()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = Math.Pow((x + 1) / (x - 1), x) + 18 * x * Math.Pow(y, 2);

                Console.WriteLine("Значение формулы 3:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_4()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = Math.Pow(1 + 1 / Math.Pow(x, 2), x) - 12 * Math.Pow(x, 2) * y;

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_5()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = Math.Pow(3, x) - 4 * x + y - Math.Sqrt(Math.Abs(x));

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_6()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = x - Math.Pow(x, Math.Sin(SpecialFunctions.DegreesToRadians(x))) + Math.Cos(SpecialFunctions.DegreesToRadians((x - y)));

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_7()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = Math.Pow(2, -x) - Math.Cos(SpecialFunctions.DegreesToRadians(x)) + Math.Sin(SpecialFunctions.DegreesToRadians((2 * x * y)));

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_8()
        {
            try
            {
                double x; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                result = Math.Exp(x) - x - 2 + Math.Pow(1 + x, x);

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2}", x);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_9()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = (x * y - 3.3 * Math.Abs(x + Math.Pow(y, 1 / 4))) / (Math.Pow(10, 7) + Math.Log(SpecialFunctions.Factorial(4)));

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f8}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_10()
        {
            try
            {
                double x; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                result = Math.Pow(x, Math.Sqrt(2)) + Math.Pow(1 + Math.Pow(x, 4), 1 / 3);

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2}", x);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_11()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = Math.Pow(x, Math.Pow(y, 2) + 3 * y - 5) + Math.Atan(SpecialFunctions.DegreesToRadians(Math.Pow(y, 4)));

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_12()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = Math.Pow((Math.Pow(x, -1 / y)) + Math.Pow(y, 3 / 2), 1 / 2) + 5 / (Math.Sin(Math.Cos(SpecialFunctions.DegreesToRadians(3 * x))));

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_13()
        {
            try
            {
                double x; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                result = 2 * 1 / Math.Tan(SpecialFunctions.DegreesToRadians(3 * x)) - 1 / (12 * Math.Pow(x, 2) + 7 * x - 5);

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2}", x);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_14()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = Math.Exp(x) - (Math.Pow(y, 2) + 12 * x * y - 3 * Math.Pow(x, 2)) / (18 * y - 1);

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_15()
        {
            try
            {
                double x; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                result = 2 * 1 / Math.Tan(SpecialFunctions.DegreesToRadians(3 * x)) - Math.Log(Math.Cos(SpecialFunctions.DegreesToRadians(x))) / Math.Log(1 + Math.Pow(x, 2));

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2}", x);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_16()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = Math.Log(Math.Abs((y - Math.Sqrt(Math.Abs(x)))) * (x - y / (x + Math.Pow(x, 2) / 4)));

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_17()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = (1 + Math.Pow(Math.Sin(SpecialFunctions.DegreesToRadians((x + y))), 2)) / (2 + Math.Abs(x - (2 * x) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2))));

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_18()
        {
            try
            {
                double x; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                result = Math.Sqrt((Math.Abs(Math.Sin(SpecialFunctions.DegreesToRadians(8 * x))) + 17) / Math.Pow(1 - Math.Sin(SpecialFunctions.DegreesToRadians(4 * x)) * Math.Cos(SpecialFunctions.DegreesToRadians((Math.Pow(x, 2) + 18))), 2));

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2}", x);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_19()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = x * Math.Log(x) + y / (Math.Cos(SpecialFunctions.DegreesToRadians(x)) - x / 3);

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_20()
        {
            try
            {
                double x; double y; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = (3 + Math.Exp(y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(SpecialFunctions.DegreesToRadians(x))));

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2} и y = {1:f2}", x, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_21()
        {
            try
            {
                double x; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                result = Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3)) - 7 * x / (Math.Pow(x, 3) - 15 * x);

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2}", x);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_22()
        {
            try
            {
                double x; double a; double result;
                Console.Write("Введите переменную x->");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную a->");
                a = Convert.ToDouble(Console.ReadLine());
                result = 1 - Math.Sqrt(3 / (3 + Math.Abs(Math.Tan(SpecialFunctions.DegreesToRadians(a * Math.Pow(x, 2))) - Math.Sin(SpecialFunctions.DegreesToRadians(a * x)))));

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для x = {0:f2} и a = {1:f2}", x, a);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_23()
        {
            try
            {
                double a; double b; double c; double result;
                Console.Write("Введите переменную a->");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную b->");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную c->");
                c = Convert.ToDouble(Console.ReadLine());
                result = (b + Math.Sqrt(Math.Pow(b, 2) + 4 * a * c)) / 2 / a - Math.Pow(a, 3) * c + Math.Pow(b, -2);

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для a = {0:f2} и b = {1:f2} и c = {2:f2}", a, b, c);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task1_24()
        {
            try
            {
                double b; double y; double result;
                Console.Write("Введите переменную a->");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите переменную y->");
                y = Convert.ToDouble(Console.ReadLine());
                result = (b + Math.Pow(Math.Sin(Math.Pow(Math.PI, 4)), 2)) / Math.Cos(SpecialFunctions.DegreesToRadians(2)) + Math.Abs(1 / Math.Tan(SpecialFunctions.DegreesToRadians(y)));

                Console.WriteLine("Значение формулы 4:");
                Console.WriteLine("Для b = {0:f2} и y = {1:f2}", b, y);
                Console.WriteLine("Результат = {0:f4}", result);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
    }
}
