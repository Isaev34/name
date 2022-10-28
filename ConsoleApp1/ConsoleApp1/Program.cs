using System;

namespace practic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Выберите какую операцию вы хотите выполнить:");
            Console.WriteLine("1. Сложите два числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два чилса");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент из числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы \n");

            bool active = true;
            string input = "";
            int num = 0;
            while (active)
            {
                Console.Write("Введите номер операции: ");
                input = Console.ReadLine();
                if (input.Length != 0)
                {
                    num = Convert.ToInt32(input);
                    int answer = 0, V1 = 0, V2 = 0;
                    switch (num)
                    {
                        case 1:
                            Console.Write("Введите первое число: ");
                            V1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите второе число: ");
                            V2 = Convert.ToInt32(Console.ReadLine());
                            answer = V1 + V2;
                            break;
                        case 2:
                            Console.Write("Введите первое число: ");
                            V1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите второе число: ");
                            V2 = Convert.ToInt32(Console.ReadLine());
                            answer = V1 - V2;
                            break;
                        case 3:
                            Console.Write("Введите первое число: ");
                            V1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите второе число: ");
                            V2 = Convert.ToInt32(Console.ReadLine());
                            answer = V1 * V2;
                            break;
                        case 4:
                            Console.Write("Введите первое число: ");
                            V1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите второе число: ");
                            V2 = Convert.ToInt32(Console.ReadLine());
                            answer = V1 / V2;
                            break;
                        case 5:
                            Console.Write("Введите первое число: ");
                            V1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите второе число: ");
                            V2 = Convert.ToInt32(Console.ReadLine());
                            answer = Convert.ToInt32(Math.Pow(V1, V2));
                            break;
                        case 6:
                            Console.Write("Введите первое число: ");
                            V1 = Convert.ToInt32(Console.ReadLine());
                            answer = Convert.ToInt32(Math.Sqrt(V1));
                            break;
                        case 7:
                            Console.Write("Введите первое число: ");
                            V1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите второе число: ");
                            V2 = Convert.ToInt32(Console.ReadLine());
                            answer = V1 / 100 * V2;
                            break;
                        case 8:
                            Console.Write("Введите первое число: ");
                            V1 = Convert.ToInt32(Console.ReadLine());
                            answer = 1;
                            for (int i = 1; i <= V1; i++) answer *= i;
                            break;
                        case 9: Environment.Exit(0); break;
                        default: active = false; Menu(); break;
                    }
                    Console.WriteLine("Ответ: {0}", answer);
                }
                else
                {
                    active = false;
                    Menu();
                }
            }
        }
    }
}
