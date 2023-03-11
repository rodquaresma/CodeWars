﻿using CodeWars.Business;
using NUnit.Framework;

namespace CodeWars.Tests
{
    public class BetterThanAverageTests
    {
        private BetterThanAverageBusiness betterThanAverageBusiness = new BetterThanAverageBusiness();

        

        [Test]
        [TestCase(new int[] { 2, 3 }, 5, ExpectedResult = true)]
        [TestCase(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75, ExpectedResult = true)]
        [TestCase(new int[] { 12, 23, 34, 45, 56, 67, 78, 89, 90 }, 69, ExpectedResult = true)]
        public bool FixedTest(int[] arr, int num)
        {
            return betterThanAverageBusiness.BetterThanAverage(arr, num);
        }
    }
}
