using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;

namespace Factorial
{
    [TestFixture]
    public class FactorialTests
    {
        private IFactorial testLib;

        [SetUp]
        public void Startup()
        {
            testLib = Substitute.For<MathLib>();
        }

        #region TestCases
        /// <summary>
        /// TestCases
        /// </summary>
        public static IEnumerable FactorialTest_TestObjects
        {
            get
            {
                yield return new TestCaseData(0, (ulong)1);
                yield return new TestCaseData(1, (ulong)1);
                yield return new TestCaseData(2, (ulong)2);
                yield return new TestCaseData(3, (ulong)6);
                yield return new TestCaseData(4, (ulong)24);
                yield return new TestCaseData(5, (ulong)120);
                yield return new TestCaseData(6, (ulong)720);
                yield return new TestCaseData(7, (ulong)5040);
                yield return new TestCaseData(8, (ulong)40320);
                yield return new TestCaseData(9, (ulong)362880);
                yield return new TestCaseData(10, (ulong)3628800);
                yield return new TestCaseData(11, (ulong)39916800);
                yield return new TestCaseData(12, (ulong)479001600);
                yield return new TestCaseData(13, (ulong)6227020800);
                yield return new TestCaseData(14, (ulong)87178291200);
                yield return new TestCaseData(15, (ulong)1307674368000);
                yield return new TestCaseData(16, (ulong)20922789888000);
                yield return new TestCaseData(17, (ulong)355687428096000);
                yield return new TestCaseData(18, (ulong)6402373705728000);
                yield return new TestCaseData(19, (ulong)121645100408832000);
                yield return new TestCaseData(20, (ulong)2432902008176640000);
                yield return new TestCaseData(null, (ulong)1);
                yield return new TestCaseData(-1, (ulong)1);
                yield return new TestCaseData(-55, (ulong)1);
                yield return new TestCaseData(-556556554, (ulong)1);
            }
        }

        /// <summary>
        /// TestCases uneven
        /// </summary>
        public static IEnumerable FactorialUnevenTest_TestObjects
        {
            get
            {
                yield return new TestCaseData(0, (ulong)1);
                yield return new TestCaseData(1, (ulong)1);
                yield return new TestCaseData(2, (ulong)1);
                yield return new TestCaseData(3, (ulong)3);
                yield return new TestCaseData(4, (ulong)3);
                yield return new TestCaseData(5, (ulong)15);
                yield return new TestCaseData(6, (ulong)15);
                yield return new TestCaseData(7, (ulong)105);
                yield return new TestCaseData(8, (ulong)105);
                yield return new TestCaseData(9, (ulong)945);
                yield return new TestCaseData(10, (ulong)945);
                yield return new TestCaseData(null, (ulong)1);
                yield return new TestCaseData(-1, (ulong)1);
                yield return new TestCaseData(-55, (ulong)1);
                yield return new TestCaseData(-556556554, (ulong)1);
            }
        }

        public static IEnumerable SquaredFactorialTest_TestObjects_TestObjects
        {
            get
            {
                yield return new TestCaseData(0,(ulong)1);
                yield return new TestCaseData(1,(ulong)1);
                yield return new TestCaseData(2,(ulong)4);
                yield return new TestCaseData(3,(ulong)36);
                yield return new TestCaseData(4, (ulong)576);
            }
        }
        #endregion

        [TestCaseSource(nameof(FactorialTest_TestObjects))]
        public void FactorialRecursiveTest_Test(int index, ulong expected)
        {
            // Act
            var result = testLib.Factorial(index);

            // Assert
            Assert.That(result == expected, $"Result: {result}");
        }

        [TestCaseSource(nameof(FactorialTest_TestObjects))]
        public void FactorialExpressionTest_Test(int index, ulong expected)
        {
            // Act
            var result = testLib.Factorial(index);

            // Assert
            Assert.That(result == expected, $"Result: {result}");
        }

        [TestCaseSource(nameof(FactorialUnevenTest_TestObjects))]
        public void FactorialUnevenRecursiveTest_Test(int index, ulong expected)
        {
            // Act
            var result = testLib.UnevenFactorial(index);

            // Assert
            Assert.That(result == expected, $"Result: {result}");
        }

        [TestCaseSource(nameof(FactorialUnevenTest_TestObjects))]
        public void FactorialUnevenExpressionTest_Test(int index, ulong expected)
        {
            // Act
            var result = testLib.UnevenFactorial(index);

            // Assert
            Assert.That(result == expected,$"Result: {result}");
        }

        [TestCaseSource(nameof(SquaredFactorialTest_TestObjects_TestObjects))]
        public void SquaredFactorialExpressionTest_TestObjects_Test(int index, ulong expected)
        {
            // Act
            var result = testLib.SquaredFactorial(index);

            // Assert
            Assert.That(result == expected, $"Result: {result}");
        }

        [TestCaseSource(nameof(SquaredFactorialTest_TestObjects_TestObjects))]
        public void SquaredFactorialRekursiveTest_TestObjects_Test(int index, ulong expected)
        {
            // Act
            var result = testLib.SquaredFactorial(index);

            // Assert
            Assert.That(result == expected, $"Result: {result}");
        }

    }
}
