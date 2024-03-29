﻿namespace IteratorDesignPattern
{
    internal interface AbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }
}