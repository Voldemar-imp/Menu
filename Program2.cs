using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;
            string login;
            string message;
            string userInput;
            int stockWindowWidth = 130;
            int stockWindowHeight = 45;
            int windowWidth = stockWindowWidth;
            int windowHeight = stockWindowHeight;
            bool isMenuWork = true;

            Console.SetWindowSize(windowWidth, windowHeight);
            Console.WriteLine("Добро пожаловать в меню управления текстовой консолью.");
            Console.WriteLine("Введите имя пользователя: ");
            login = Console.ReadLine();
            message = login;
            Console.WriteLine("Введите пароль: ");
            password = Console.ReadLine();
            message = login;
            Console.Clear();

            while (isMenuWork)
            {
                Console.SetWindowSize(windowWidth, windowHeight);
                Console.WriteLine("Добро пожаловать в меню управления рекламным баннером.");
                Console.WriteLine("Введите одну из управляющих команд: \n" +
                    "ConsoleColorGreen - изменить цвет консоли на зеленый \n" +
                    "ConsoleColorBlue - изменить цвет консоли на синий \n" +
                    "TextColorYellow - изменить цвет текста на желтый  \n" +
                    "TextColorRed - изменить цвет текста красный \n" +
                    "ChangeConsoleSize  - изменить размер консоли \n" +
                    "SetStockSettings - установить базовые настройки консоли \n" +
                    "SetMessage -  ввести сообщение (по умолчанию - имя пользователя) \n" +
                    "OutputMessage - вывести сообщение (требуется ввод пароля) \n" +
                    "Exit - для выхода из меню");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "ConsoleColorGreen":
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case "ConsoleColorBlue":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case "TextColorYellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "TextColorRed":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "ChangeConsoleSize":
                        Console.Write("Введите ширину консоли: ");
                        windowWidth = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите высоту консоли: ");
                        windowWidth = Convert.ToInt32(Console.ReadLine());
                        Console.SetWindowSize(windowWidth, windowHeight);
                        break;
                    case "SetStockSettings":
                        windowWidth = stockWindowWidth;
                        windowHeight = stockWindowHeight;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetWindowSize(windowWidth, windowHeight);
                        break;
                    case "SetMessage":
                        Console.Write("Введите сообщение: ");
                        message = Console.ReadLine();
                        break;
                    case "OutputMessage":
                        Console.Write("Введите пароль: ");
                        userInput = Console.ReadLine();

                        if (userInput == password)
                        {
                            Console.Clear();
                            Console.SetCursorPosition((windowWidth - message.Length) / 2, windowHeight / 2);
                            Console.WriteLine(message);
                        }
                        else 
                        {
                            Console.WriteLine("Пароль неверный");
                        }
                        break;
                        
                    case "Exit":
                        isMenuWork = false;
                        Console.WriteLine("Благодарим за работу с консолью. Хорошего дня!");
                        break;
                    default:
                        Console.WriteLine("Неверно введена команда, поробуйте еще раз");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
