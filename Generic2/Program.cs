using System;

namespace Generic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 11, 2, 45, 20, -8, 9 };
            Console.WriteLine($"Минимальное: { FindMin(numbers)}");

            string[] words = {"apple", "banana", "books", "pen" };
            Console.WriteLine($"Минимальное: {FindMin(words)}");

            Console.ReadLine();
        }
        public static T FindMin<T>(T[] mas) where T: IComparable<T>
        {
            T min = mas[0];
            foreach (T t in mas)
            {
                if(t.CompareTo(min)<0)
                    min = t;
            }
            return min;
        } 
    }
}
