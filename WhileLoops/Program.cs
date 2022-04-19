using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Программа просит пользователя ввести ПИН-код
            //Программа проверяет, соответствует ли введённый ПИН-код значение"1234"
            //Если введённое значение соответствует *1234*, в консоли вводится *Welcome*
            // и программа завершает свою работу
            //Если введённый ПИН-код неверный, то программа просит ввести код снова
            //у пользователя 3 попытки

            //Bool LoopActive = true;
            int tries = 0;
            while (tries != 3)
            {
                Console.WriteLine("Enter your PIN:");
                string userPIN = Console.ReadLine();

                if (userPIN == "1234")
                {
                    Console.WriteLine("Welcome");
                    break;
                    //loopActive = false;
                }
                else
                {
                    Console.WriteLine("Invalid PIN. Try again");
                    tries++;
                    Console.WriteLine($"You have made {tries} attempts.");
                }
            }
            Console.WriteLine("Have a nice day.");
        }
    }
}
