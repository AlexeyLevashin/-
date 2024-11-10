using System;
using System.Collections.Generic;

namespace Generic5
{
    public class ListStorage<T>:IStorage<T>
    {
        List<T> list = new List<T>();
        public void Add(T element) 
        {
            if (element == null)
                throw new ArgumentNullException("Элемент не должен быть пустым");
            list.Add(element);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= list.Count)
                throw new ArgumentOutOfRangeException("Индекс не должен выходить за границы списка");
            return list[index];
        }
    }
}
