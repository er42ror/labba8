using NUnit.Framework;
using System;

namespace labtest2
{
    [TestFixture()]
    public class Test
    {
        [SetUp]

        [Test]
        public void BubbleSort_test_1()
        {
            int[] array = { 5, 3, 2, 4, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            int[] result = MyFunctions.SortIntArray(array);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void BubbleSort_test_2()
        {
            int[] array = { 5, 1, 4, 2, 3 };
            int[] expected = { 1, 2, 3, 4, 5 };

            int[] result = MyFunctions.SortIntArray(array);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void BubbleSort_test_3()
        {
            int[] array = { 3, 7, 1, 9, 2 };
            int[] expected = { 1, 2, 3, 7, 9 };

            int[] result = MyFunctions.SortIntArray(array);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void BubbleSort_test_4()
        {
            int[] array = { 8, 6, 4, 2, 0 };
            int[] expected = { 0, 2, 4, 6, 8 };

            int[] result = MyFunctions.SortIntArray(array);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Palindrome_test_1()
        {
            string palindromeString = "level";
            string nonPalindromeString = "hello";

            bool isPalindrome = MyFunctions.IsPalindrome(palindromeString);
            bool isNonPalindrome = MyFunctions.IsPalindrome(nonPalindromeString);

            Assert.IsTrue(isPalindrome);
            Assert.IsFalse(isNonPalindrome);
        }

        [Test]
        public void Palindrome_test_2()
        {
            string palindromeString = "deified";
            string nonPalindromeString = "world";

            bool isPalindrome = MyFunctions.IsPalindrome(palindromeString);
            bool isNonPalindrome = MyFunctions.IsPalindrome(nonPalindromeString);

            Assert.IsTrue(isPalindrome);
            Assert.IsFalse(isNonPalindrome);
        }

        [Test]
        public void Palindrome_test_3()
        {
            string palindromeString = "radar";
            string nonPalindromeString = "hello";

            bool isPalindrome = MyFunctions.IsPalindrome(palindromeString);
            bool isNonPalindrome = MyFunctions.IsPalindrome(nonPalindromeString);

            Assert.IsTrue(isPalindrome);
            Assert.IsFalse(isNonPalindrome);
        }

        [Test]
        public void Palindrome_test_4()
        {
            string palindromeString = "madam";
            string nonPalindromeString = "open";

            bool isPalindrome = MyFunctions.IsPalindrome(palindromeString);
            bool isNonPalindrome = MyFunctions.IsPalindrome(nonPalindromeString);

            Assert.IsTrue(isPalindrome);
            Assert.IsFalse(isNonPalindrome);
        }

        [Test]
        public void TestFactorial_1()
        {
            int factorialOfFive = 120;

            int calculatedFactorial = MyFunctions.Factorial(5);

            Assert.AreEqual(factorialOfFive, calculatedFactorial);
        }

        [Test]
        public void TestFactorial_2()
        {
            int factorialOfSix = 720;

            int calculatedFactorial = MyFunctions.Factorial(6);

            Assert.AreEqual(factorialOfSix, calculatedFactorial);
        }

        [Test]
        public void TestFactorial_3()
        {
            int factorialOfThree = 6;

            int calculatedFactorial = MyFunctions.Factorial(3);

            Assert.AreEqual(factorialOfThree, calculatedFactorial);
        }

        [Test]
        public void TestFactorial_4()
        {
            int factorialOfZero = 1;

            int calculatedFactorial = MyFunctions.Factorial(0);

            Assert.AreEqual(factorialOfZero, calculatedFactorial);
        }

        [Test]
        public void TestFibonacci_1()
        {
            int fibonacciAtPosition7 = 13;

            int calculatedFibonacci = MyFunctions.Fibonacci(7);

            Assert.AreEqual(fibonacciAtPosition7, calculatedFibonacci);
        }

        [Test]
        public void TestFibonacci_2()
        {
            int fibonacciAtPosition10 = 55;

            int calculatedFibonacci = MyFunctions.Fibonacci(10);

            Assert.AreEqual(fibonacciAtPosition10, calculatedFibonacci);
        }

        [Test]
        public void TestFibonacci_3()
        {
            int fibonacciAtPosition4 = 3;

            int calculatedFibonacci = MyFunctions.Fibonacci(4);

            Assert.AreEqual(fibonacciAtPosition4, calculatedFibonacci);
        }

        [Test]
        public void TestFibonacci_4()
        {
            int fibonacciAtPosition2 = 1;

            int calculatedFibonacci = MyFunctions.Fibonacci(2);

            Assert.AreEqual(fibonacciAtPosition2, calculatedFibonacci);
        }

        [Test]
        public void TestPower_1()
        {
            double expectedResult = 8.0;

            double result = MyFunctions.Power(2.0, 3.0);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestPower_2()
        {
            double expectedResult = 27.0;

            double result = MyFunctions.Power(3.0, 3.0);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestPower_3()
        {
            double expectedResult = 1024.0;

            double result = MyFunctions.Power(2.0, 10.0);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestPower_4()
        {
            double expectedResult = 625.0;

            double result = MyFunctions.Power(5.0, 4.0);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TestIsPrime_1()
        {
            int primeNumber = 17;
            int nonPrimeNumber = 10;

            bool isPrime = MyFunctions.IsPrime(primeNumber);
            bool isNotPrime = MyFunctions.IsPrime(nonPrimeNumber);

            Assert.IsTrue(isPrime);
            Assert.IsFalse(isNotPrime);
        }

        [Test]
        public void TestIsPrime_2()
        {
            int primeNumber = 23;
            int nonPrimeNumber = 15;

            bool isPrime = MyFunctions.IsPrime(primeNumber);
            bool isNotPrime = MyFunctions.IsPrime(nonPrimeNumber);

            Assert.IsTrue(isPrime);
            Assert.IsFalse(isNotPrime);
        }

        [Test]
        public void TestIsPrime_3()
        {
            int primeNumber = 31;
            int nonPrimeNumber = 20;

            bool isPrime = MyFunctions.IsPrime(primeNumber);
            bool isNotPrime = MyFunctions.IsPrime(nonPrimeNumber);

            Assert.IsTrue(isPrime);
            Assert.IsFalse(isNotPrime);
        }

        [Test]
        public void TestIsPrime_4()
        {
            int primeNumber = 37;
            int nonPrimeNumber = 27;

            bool isPrime = MyFunctions.IsPrime(primeNumber);
            bool isNotPrime = MyFunctions.IsPrime(nonPrimeNumber);

            Assert.IsTrue(isPrime);
            Assert.IsFalse(isNotPrime);
        }
    }
}
