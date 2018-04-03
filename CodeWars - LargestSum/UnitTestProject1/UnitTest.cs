using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using NUnit.Framework;

namespace LargestSumTest
{
    [TestFixture]
    public class UnitTest
    {
        [TestCase(new[] { -1, -2, -3 }, ExpectedResult = 0)]
        [TestCase(new int[0], ExpectedResult = 0)]
        [TestCase(new[] { 1, 2, 3, 4 }, ExpectedResult = 10)]
        [TestCase(new[] { 31, -41, 59, 26, -53, 58, 97, -93, -23, 84 }, ExpectedResult = 187)]
        [TestCase(new[] { 31, -41, 59, 26, -53, 58, 97, -1, -23, 84 }, ExpectedResult = 247)]
        public int MultipleTest(int[] input)
        {
            return Kata.LargestSum(input);
        }
    }
}
