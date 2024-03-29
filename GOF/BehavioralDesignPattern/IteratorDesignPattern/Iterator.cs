﻿namespace IteratorDesignPattern
{
    internal class Iterator : AbstractIterator
    {
        private readonly ConcreteCollection collection;
        private int current = 0;
        private readonly int step = 1;
        // Constructor
        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
        // Gets first item
        public Employee First()
        {
            current = 0;
            return collection.GetEmployee(current);
        }
        // Gets next item
        public Employee Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetEmployee(current);
            }
            else
            {
                return null;
            }
        }
        // Check whether iteration is complete
        public bool IsCompleted => current >= collection.Count;
    }
}