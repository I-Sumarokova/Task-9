using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вас приветствует калькулятор!");
            
            try          
            { 
            Console.WriteLine("Введите целое число х= ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введиет целое число y= ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите код операции: ");
            Console.WriteLine("1 - сложение ");
            Console.WriteLine("2 - вычитание ");
            Console.WriteLine("3 - произведение ");
            Console.WriteLine("4 - частное ");

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш выбор: {0}", n);

                if (n > 0 && n <5)
                {
                    switch (n)
                    {
                        case 1:
                            {
                                Console.WriteLine("Результат ={0}", x + y);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Результат ={0}", x - y);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Результат ={0}", x * y);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Результат ={0}", x / y);
                                break;
                            }
                    }
                }
                else 
                {
                    Console.WriteLine("Нет операций с указанным номером");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
