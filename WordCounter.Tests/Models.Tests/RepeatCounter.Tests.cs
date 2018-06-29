﻿using System;
using WordCounter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordCounter.Tests

{
    [TestClass]
    public class RepeatCounterTests
    {
        [TestMethod]
        public void GetWordCounter_ReturnCurrentValueOfWordCounter_Int()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter();

            //Act
            int result = newRepeatCounter.GetWordCounter();

            //Assert
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void SetGetWordToFind_SetAndGetValueOfWordToFind_String()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            string testWord = "back";

            //Act
            newRepeatCounter.SetWordToFind(testWord);
            string resultWord = newRepeatCounter.GetWordToFind();

            //Assert
            Assert.AreEqual(resultWord, testWord);
        }
    }
}