namespace Core.Interfaces;

public interface IPushable<in T>
{
    void Push(T animal);
}