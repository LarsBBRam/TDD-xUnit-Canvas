namespace Core.Classes;

using System.Collections.Generic;
using Core.Interfaces;

public class AnimalPen<T>(int penSize) : IPoppable<T>, IPushable<T>
{
    private int _position;
    private T[] _pen = new T[penSize];

    public int Count => _position;

    public int Size => penSize;
    public T Pop()
    {
        ArgumentOutOfRangeException.ThrowIfEqual(_position, 0);
        return _pen[--_position];
    }

    public void Push(T animal)
    {
        ArgumentOutOfRangeException.ThrowIfEqual(penSize, _position); _pen[_position++] = animal;
    }
}