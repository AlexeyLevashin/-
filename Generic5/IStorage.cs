using System;

namespace Generic5
{
    public interface IStorage<T>
    {
        void Add(T el);
        T Get(int ind);
    }
}
