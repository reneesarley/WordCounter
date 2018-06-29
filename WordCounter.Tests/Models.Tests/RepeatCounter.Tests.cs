using System;
using WordCounter;
using System.Collections.Generic;
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

        [TestMethod]
        public void SetGetStringToSearch_SetAndGetValueOfStringToSearch_String()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            string testString = "Bob fell on his back";

            //Act
            newRepeatCounter.SetStringToSearch(testString);
            string resultString = newRepeatCounter.GetStringToSearch();

            //Assert
            Assert.AreEqual(resultString, testString);
        }

        [TestMethod]
        public void CompareWords_ReturnOneWhenWordsMatch_Int()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            string testWord = "back";

            //Act
            int result =newRepeatCounter.CompareWords(testWord, testWord);

            //Assert
            Assert.AreEqual(result, 1);
        }
        [TestMethod]
        public void CompareWords_ReturnZeroWhenWordsDontMatch_Int()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            string testWord = "back";
            string testWordTwo = "backNot";

            //Act
            int result = newRepeatCounter.CompareWords(testWord, testWordTwo);

            //Assert
            Assert.AreEqual(result, 0);
        }
        [TestMethod]
        public void CompareWords_ConvertUpperCaseToLower_Int()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            string testWord = "BACK";
            string testWordTwo = "back";
           

            //Act
            int resultOne = newRepeatCounter.CompareWords(testWord, testWordTwo);
            int resultTwo = newRepeatCounter.CompareWords(testWordTwo, testWord);


            //Assert
            Assert.AreEqual(resultOne, 1);
            Assert.AreEqual(resultTwo, 1);
        }

        [TestMethod]
        public void ConvertStringToList_()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            string testString = "Bob fell on his back";
            List<string> testList = new List<string>(){ "Bob", "didnt", "fell", "on", "his", "back" };

            //Act
            List<string> resultList = newRepeatCounter.ConvertStringToList(testString);

            //Assert
            CollectionAssert.AreEqual(resultList, testList);
        }
    }
}
