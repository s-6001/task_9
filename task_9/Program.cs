using System;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                int x = 0, y = 0;   // числа для проведения операции
                byte operation = 0;     // код операции
                bool mistake = false;   //есть ошибка?
                Console.Write("Введите целое число. X=");
                try //обрабатываем исключение если не удается конвертировать в число
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ошибка! Входная строка имела неверный формат.");
                    mistake = true;
                }
                if (mistake == false) //если первое число корректно, то продолжаем
                {
                    Console.Write("Введите целое число. Y=");
                    try //обрабатываем исключение если не удается конвертировать в число
                    {
                        y = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Входная строка имела неверный формат.");
                        mistake = true;
                    }
                }
                if (mistake == false)   //если оба числа корректны, то продолжаем
                {
                    Console.WriteLine("Введите код операции:");
                    Console.WriteLine("1 - сложение");
                    Console.WriteLine("2 - вычитание");
                    Console.WriteLine("3 - произведение");
                    Console.WriteLine("4 - частное");
                    Console.Write("Ваш выбор: ");
                    try
                    {
                        operation = Convert.ToByte(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Входная строка имела неверный формат.");
                        mistake = true;
                    }
                    if (mistake == false)   //если оба числа и код операции корректны, то продолжаем
                    {
                        switch (operation) //выбираем операцию по коду и выводим результат
                        {
                            case 1:
                                Console.WriteLine("Результат = {0}", x + y);
                                break;
                            case 2:
                                Console.WriteLine("Результат = {0}", x - y);
                                break;
                            case 3:
                                Console.WriteLine("Результат = {0}", x * y);
                                break;
                            case 4:
                                Console.WriteLine("Результат = {0}", x / y);
                                break;
                            default:
                                Console.WriteLine("Нет операции с указанным номером");
                                break;
                        }
                    } 
                }
                Console.WriteLine("");
            }
        }
    }
}