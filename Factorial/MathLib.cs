using System;
using System.Linq;

namespace Factorial
{
    public class MathLib : IFactorial
    {
        /// <summary>
        /// Fakultät via Rekursion
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public ulong Factorial(ulong index)
        {
            if (index <= 1)
                return 1;

            return index * Factorial(index - 1);
        }

        /// <summary>
        /// Fakultiät via Expression
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public ulong Factorial(int index)
        {
            if (index <= 1)
                return 1;

            var fac = Enumerable.Range(1, index)
                .Select(range => (ulong)range)
                .Aggregate((next, aggregate) => aggregate * next);

            return fac;
        }

        /// <summary>
        /// Fakultät via Rekursion für ungerade Werte
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public ulong UnevenFactorial(ulong index)
        {
            if (index <= 1)
                return 1;

            if (index % 2 == 0)
                return UnevenFactorial(index - 1);

            return index * UnevenFactorial(index-1);
        }

        /// <summary>
        /// Fakultät via Expression für ungerade Werte
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public ulong UnevenFactorial(int index)
        {
            if (index <= 1)
                return 1;

            var fac = Enumerable.Range(1, index)
                .Where(range => range%2 != 0)
                .Select(range => (ulong)range)
                .Aggregate((next, aggregate) => aggregate * next);

            return fac;
        }

        public ulong SquaredFactorial(ulong index)
        {
            if (index <= 1)
                return 1;

            return (ulong)Math.Pow(index,2) * SquaredFactorial(index-1);
        }

        public ulong SquaredFactorial(int index)
        {
            if (index <= 1)
                return 1;

            var fac = Enumerable.Range(1, index)
                .Select(range => (double) range)
                .Aggregate((next, aggregate) => Math.Pow(aggregate, 2) * next);

            return (ulong) fac;
        }
    }
}