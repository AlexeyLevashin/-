using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            Console.WriteLine("Приветсвуем вас в приложении нашего банка.\n" +
                "Сейчас вам будет предложено ввести исходный баланс.\n" +
                "При вводе не целого числа копейки будут списаны банком в качестве комиссии.");
            Console.Write("Введите ваш исходный баланс: ");

            int value=0;
            bankAccount.CorrectInput(Console.ReadLine(), ref value);
            bankAccount.SetBalanseValue(value);
            Console.WriteLine($"Ваш баланс: {bankAccount.GetBalanseValue()}");

            Console.WriteLine("Выберите, какую операцию хотите произвести ");
            Console.WriteLine($"Введите 1, если хотитите пополнить счет");
            Console.WriteLine($"Введите 2, если хотитите снять деньги со счета");
            Console.WriteLine($"Введите 3, если хотитите покинуть приложение банка");

            while (true)
            {
                Console.Write("Введите номер операции: ");
                bankAccount.CorrectInput(Console.ReadLine(), ref value);
                if (value == 1)
                {
                    Console.WriteLine("Введите сумму пополнения: ");
                    bankAccount.CorrectInput(Console.ReadLine(), ref value);
                    bankAccount.AddMoney(value);
                }
                else if(value == 2)
                {
                    Console.WriteLine("Введите сумму, которую хотите снять: ");
                    bankAccount.CorrectInput(Console.ReadLine(), ref value);
                    bankAccount.GetMoney(value);
                }
                else if(value == 3)
                {
                    break;                  
                }
                Console.WriteLine($"Ваш текущий баланс: {bankAccount.GetBalanseValue()}");
            }

            Console.WriteLine($"Нажмите  {"Enter"}");
            Console.ReadLine();
            
        }
    }
}
