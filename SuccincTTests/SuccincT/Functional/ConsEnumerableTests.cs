﻿using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SuccincT.Functional;

namespace SuccincTTests.SuccincT.Functional
{
    [TestFixture]
    public class ConsEnumerableTests
    {
        [Test]
        public void ListConvertedToCons_CanBeEnumerated()
        {
            var list = new List<int> { 1, 2, 3 };
            var consList = list.ToConsEnumerable();
            var count = consList.Aggregate((x, y) => x + y);
            Assert.AreEqual(6, count);
        }
        [Test]
        public void EmptyListConvertedToCons_CanBeEnumerated()
        {
            var list = new List<int>();
            var consList = list.ToConsEnumerable();
            var count = consList.Count();
            Assert.AreEqual(0, count);
        }

        [Test]
        public void EnumerationConvertedToCons_CanBeEnumeratedManyTimesWithoutReRunningOriginalEnumeration()
        {
            var enumRunCount = 0;
            var cons = EnumerationWithNotificationOfEnd(() => enumRunCount++).ToConsEnumerable();
            var joinedString1 = cons.Aggregate((x, y) => x + y);
            var joinedString2 = cons.Aggregate((x, y) => x + y);
            Assert.AreEqual("redgreenblue", joinedString1);
            Assert.AreEqual("redgreenblue", joinedString2);
            Assert.AreEqual(1, enumRunCount);
        }

        [Test]
        public void ItemAddedToList_ResultsInItAndOriginalListAllBeingEnumerated()
        {
            var list = new List<int> { 2, 3, 4 };
            var consList = list.Cons(1);
            var count = consList.Aggregate((x, y) => x + y);
            Assert.AreEqual(10, count);
        }

        [Test]
        public void ItemAddedToEmptyList_ResultsInItBeingEnumerated()
        {
            var list = new List<int>();
            var consList = list.Cons(1);
            var count = consList.Aggregate((x, y) => x + y);
            Assert.AreEqual(1, count);
        }

        [Test]
        public void ManyItemsAddedToList_ResultsInThemAndOriginalListAllBeingEnumerated()
        {
            var list = new List<int> { 4, 5, 6 };
            var consList1 = list.Cons(3);
            var consList2 = consList1.Cons(2);
            var consList3 = consList2.Cons(1);
            var count = consList3.Aggregate((x, y) => x + y);
            Assert.AreEqual(21, count);
        }

        [Test]
        public void EnumerationConvertedToConsAndItemsAdded_CanBeEnumeratedManyTimesWithoutReRunningOriginalEnumeration()
        {
            var enumRunCount = 0;
            var cons1 = EnumerationWithNotificationOfEnd(() => enumRunCount++).ToConsEnumerable();
            var cons2 = cons1.Cons("yellow");
            var joinedString1 = cons2.Aggregate((x, y) => x + y);
            var joinedString2 = cons2.Aggregate((x, y) => x + y);
            Assert.AreEqual("yellowredgreenblue", joinedString1);
            Assert.AreEqual("yellowredgreenblue", joinedString2);
            Assert.AreEqual(1, enumRunCount);
        }

        [Test]
        public void WhenListsAndItemsAddedToList_ResultsInThemAllBeingEnumerated()
        {
            var list1 = new List<int> { 1, 2 };
            var list2 = new List<int> { 3, 4 };
            var consList1 = list1.Cons(new List<int> { 5, 6, });
            var consList2 = list2.Cons(7);
            var consList3 = consList2.Cons(new List<int> { 8, 9 });
            var consList4 = consList1.Cons(consList3);
            var count = consList4.Aggregate((x, y) => x + y);
            Assert.AreEqual(45, count);
        }

        [Test]
        public void SplittingEnumerationViaCons_DoesntFullyEnumerateEnumeration()
        {
            var enumRunCount = 0;
            EnumerationWithNotificationOfEnd(() => enumRunCount++).Cons();
            Assert.AreEqual(0, enumRunCount);
        }

        [Test]
        public void SplittingEnumerationViaCons_AllowsRemainingEnumerationToBeEnumeratedAndHeadCorrectValue()
        {
            var consData = new List<int> { 1, 2, 3, 4 }.Cons();
            var count = consData.Tail.Aggregate((x, y) => x + y);
            Assert.AreEqual(1, consData.Head.Value);
            Assert.AreEqual(9, count);
        }

        [Test]
        public void SplittingOneElementEnumerationViaCons_GivesEmptyTail()
        {
            var consData = new List<int> { 1 }.Cons();
            var count = consData.Tail.Count();
            Assert.AreEqual(1, consData.Head.Value);
            Assert.AreEqual(0, count);
        }

        [Test]
        public void SplittingEmptyEnumerationViaCons_GivesEmptyTailAndNoneForHead()
        {
            var consData = new List<int>().Cons();
            var count = consData.Tail.Count();
            Assert.IsFalse(consData.Head.HasValue);
            Assert.AreEqual(0, count);
        }

        [Test]
        public void SplittingEnumerationViaCons_AllowsAllowsOriginalEnumerationToBeEnumeratedCorrectly()
        {
            var consList = new List<int> {1, 2, 3, 4}.ToConsEnumerable();
            var consData = consList.Cons();
            var count1 = consData.Tail.Aggregate((x, y) => x + y);
            var count2 = consList.Aggregate((x, y) => x + y);
            Assert.AreEqual(9, count1);
            Assert.AreEqual(10, count2);
        }

        [Test]
        public void ForEach_WorksWithConsEnumerable()
        {
            var enumRunCount = 0;
            var result = "";
            var cons = EnumerationWithNotificationOfEnd(() => enumRunCount++).ToConsEnumerable();

            for (var i = 0; i < 10; i++)
            {
                foreach (var item in cons)
                {
                    result += item.Substring(0, 1);
                }

            }

            Assert.AreEqual(1, enumRunCount);
            Assert.AreEqual("rgbrgbrgbrgbrgbrgbrgbrgbrgbrgb", result);
        }

        private static IEnumerable<string> EnumerationWithNotificationOfEnd(Action endReached)
        {
            yield return "red";
            yield return "green";
            yield return "blue";
            endReached();
        }
    }
}
