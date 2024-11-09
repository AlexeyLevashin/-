using System;

namespace Encapsulation
{
    public class BankAccount
    {
        private int Balance;

        public int GetBalanseValue()
        {
            return Balance; 
        }
        public void SetBalanseValue(int balance)
        {
            Balance = balance;            
        }

        public void AddMoney(int value)
        {
            if(value > 0)
            {
                Balance += value;
            }
            else
                Console.WriteLine("Сумма пополнения должна быть положительной");
        }

        public void GetMoney(int value) {
            if ((value > 0) && (Balance - value >= 0))
            {
                Balance -= value;
            }
            else if (value <= 0)
                Console.WriteLine("Сумма списания должна быть положительной");
            else
                Console.WriteLine("На счете недостаточно средств");

         }
         
        public void CorrectInput(string input, ref int output)
        {
            while (true)
            {
                if (double.TryParse(input, out var number))
                {
                    output = Convert.ToInt32(Math.Floor(number));
                    break;
                }
                else
                {
                    Console.WriteLine($"Вам нужно ввести значение в числовом формате, например: {"107"} ");
                    Console.Write("Введите значение: ");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
