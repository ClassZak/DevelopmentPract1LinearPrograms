


using System.Reflection;

namespace DevelopmentPract1LinearPrograms
{
    internal class Program
    {
        static void TaskDescription(ushort number)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Задание {0}:", number);
            Console.ResetColor ();
        }
        static void Pause()
        {
            Console.ReadKey();
            Console.Clear();
        }
        static void FirstPart()
        {
            try
            {
                System.Reflection.Assembly asm;
                asm = System.Reflection.Assembly.Load("Tasks");
                Type FType = asm.GetType("Tasks.FirstPart");
                object tObj = Activator.CreateInstance(FType);

                for(ushort i=1;i<=24;++i)
                {
                    TaskDescription(i);
                    MethodInfo method = FType.GetMethod("Task1_"+i.ToString());
                    method.Invoke(tObj, null);
                    Pause();
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Все задания первой части выполнены!");
                Console.ResetColor();
                Console.WriteLine("Для продолжения нажмите клавишу . . .");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Непредвиденная ошибка при выполнении первой части!");
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static void SecondPart()
        {
            try
            {
                System.Reflection.Assembly asm;
                asm = System.Reflection.Assembly.Load("Tasks");
                Type SType = asm.GetType("Tasks.SecondPart");
                object tObject = Activator.CreateInstance(SType);
                MethodInfo method;
                TaskDescription(5);
                method = SType.GetMethod("Task2_5");
                method.Invoke(tObject, null);
                Pause();
                TaskDescription(33);
                method = SType.GetMethod("Task2_33");
                method.Invoke(tObject, null);
                Pause();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Все задания второй части выполнены!");
                Console.ResetColor();
                Console.WriteLine("Для продолжения нажмите клавишу . . .");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Непредвиденная ошибка при выполнении второй части!");
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
            FirstPart();
            SecondPart();
        }
    }
}
