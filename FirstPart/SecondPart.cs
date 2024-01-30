namespace Tasks
{
    public class SecondPart
    {
        static public void Task2_5()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Алгоритм исследования числа");
                Console.ResetColor();



                Console.Write("Введите вещественное число A->");
                double A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Целая часть числа {0:f0}:", A);
                {
                    string floatingPart = (Math.Floor((A - Math.Floor(A)) * Math.Pow(10, 4)) / Math.Pow(10, 4)).ToString();
                    if (floatingPart.Length > 2)
                        floatingPart = floatingPart.Substring(2);
                    else
                        floatingPart = "0";
                    Console.WriteLine("Дробная часть числа :" + floatingPart);
                }
                Console.WriteLine("Символ, код котрого равен целой части числа A: \"" + (char)(Math.Floor(A)) + "\"");
                Console.WriteLine("Квадратный корень числа A = {0:f4}", Math.Sqrt(A));
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static public void Task2_33()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Алгоритм вычисления количества краски");
                Console.ResetColor();



                Console.Write("Введите расход краски (грамм) на 1 квадратный метр->");
                double расход = Convert.ToDouble(Console.ReadLine());
                if (расход <= 0)
                    throw new Exception("Ошибка! Неверный расход краски");
                Console.Write("Введите площадь стола (квадратные метры)->");
                double площадьСтола = Convert.ToDouble(Console.ReadLine());
                if (площадьСтола <= 0)
                    throw new Exception("Ошибка! Неверная площадь стола!");

                double количествоКраски = площадьСтола * расход;
                Console.WriteLine("Количество краски (грамм), которое нужно потратить на покраску стола:" + количествоКраски);

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
