using System.Runtime.Intrinsics.X86;

namespace Core.Interfaces;

public interface IPoppable<out T>
{
    T Pop();
}