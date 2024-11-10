using System;

namespace Generic5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IStorage<int> storage = new ListStorage<int>();
            try
            {
                storage.Add(36);
                storage.Add(12);
                storage.Add(0);
                Console.WriteLine(storage.Get(1));
            }
            catch(ArgumentNullException e) {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
