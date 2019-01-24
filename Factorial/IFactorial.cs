namespace Factorial
{
    public interface IFactorial
    {
        ulong Factorial(ulong index);
        ulong Factorial(int index);
        ulong UnevenFactorial(ulong index);
        ulong UnevenFactorial(int index);
        ulong SquaredFactorial(ulong index);
        ulong SquaredFactorial(int index);
    }
}