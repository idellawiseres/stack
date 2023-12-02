using System;
using System.Collections.Generic;

public class Stack<T>
{
    private int _size;
    private readonly List<T> _data;
    
    public Stack()
    {
        _data = new List<T>();
        _size = 0;
    }

    public int Size()
    {
        return _size;
    }

    public void Push(T item)
    {
        _data.Add(item);
        _size++;
    }

    public T Peek()
    {
        
        if (Size() == 0)
        {
            throw new Exception("Stack is empty");
        }

        return _data[_size - 1];
    }

    public T Pop()
    {
        var item = Peek();
        _data.Remove(item);
        _size--;
        return item;
    }

    public void Clear()
    {
        _data.Clear();
        _size = 0;
    }
}
