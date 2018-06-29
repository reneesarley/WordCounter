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
            //Arange
            RepeatCounter newRepeatCounter = new RepeatCounter();

            //Act
            int result = newRepeatCounter.GetWordCounter();

            //Assert
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void SetGetWordToFind_SetAndGetValueOfWordToFind_String()
        {
            //Arange
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
            //Arange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            string testString = "Bob fell on his back";

            //Act
            newRepeatCounter.SetStringToSearch(testString);
            string resultString = newRepeatCounter.GetStringToSearch();

            //Assert
            Assert.AreEqual(resultString, testString);
        }

        [TestMethod]
        public void UpdateWordCounter_ReturnOneWhenWordsMatch_Int()
        {
            //Arange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            string testWord = "back";
            string testSentence = "Bob fell on his back";

            //Act
            newRepeatCounter.SetWordToFind(testWord);
            newRepeatCounter.SetStringToSearch(testSentence);
            newRepeatCounter.UpdateWordCounter();
            int result = newRepeatCounter.GetWordCounter();

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void UpdateWordCount_ReturnZeroWhenWordsDontMatch_Int()
        {
            //Arange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            string testWord = "back";
            string testSentence = "Bob fell backwards";

            //Act
            newRepeatCounter.SetWordToFind(testWord);
            newRepeatCounter.SetStringToSearch(testSentence);
            newRepeatCounter.UpdateWordCounter();
            int result = newRepeatCounter.GetWordCounter();

            //Assert
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void UpdateWordCounter_ReturnOneWhenWordWithPuncMatches_Int()
        {
            //Arange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            string testWord = "back";
            string testSentence = "Bob feel on his back.";

            //Act
            newRepeatCounter.SetWordToFind(testWord);
                newRepeatCounter.SetStringToSearch(testSentence);
                newRepeatCounter.UpdateWordCounter();
                int result = newRepeatCounter.GetWordCounter();

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void UpdateWordCounter_ConvertUpperCaseToLower_Int()
        {
            //Arange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            string testWord = "back";
            string testSentence = "Bob fell BACK";

            //Act
            newRepeatCounter.SetWordToFind(testWord);
            newRepeatCounter.SetStringToSearch(testSentence);
            newRepeatCounter.UpdateWordCounter();
            int result = newRepeatCounter.GetWordCounter();

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void UpdateWordCounter_ReturnOneDueToOneMatchingWord_Int()
        {
            //Arange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            newRepeatCounter.SetStringToSearch("Bob fell on his back");
            newRepeatCounter.SetWordToFind("back");
            string testSentence = newRepeatCounter.GetStringToSearch();
            string testWord = newRepeatCounter.GetWordToFind();


            //Act
            newRepeatCounter.UpdateWordCounter();
            int result = newRepeatCounter.GetWordCounter();

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void UpdateWordCounter_ReturnThreeDueToThreeMatchingWords_Int()
        {
            //Arange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            newRepeatCounter.SetStringToSearch("Bob fell on his back but didn't hurt his back so he got back up");
            newRepeatCounter.SetWordToFind("back");
            string testSentence = newRepeatCounter.GetStringToSearch();
            string testWord = newRepeatCounter.GetWordToFind();


            //Act
            newRepeatCounter.UpdateWordCounter();
            int result = newRepeatCounter.GetWordCounter();

            //Assert
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void UpdateWordCounter_ReturnZeroDueToNoMatchingWords_Int()
        {
            //Arange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            newRepeatCounter.SetStringToSearch("Bob fell on his face");
            newRepeatCounter.SetWordToFind("back");
            string testSentence = newRepeatCounter.GetStringToSearch();
            string testWord = newRepeatCounter.GetWordToFind();


            //Act
            newRepeatCounter.UpdateWordCounter();
            int result = newRepeatCounter.GetWordCounter();

            //Assert
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void StripPunctuation_RemoveAllPunctuation_String()
        {
            //Arange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            string testWord = "back.";

            //Act
            string result = newRepeatCounter.StripPunctuation(testWord);

            //Assert
            Assert.AreEqual(result, "back");
        }
        [TestMethod]
        public void StripPunctuation_OnlyRemovePunctuationAtEndOfWord_String()
        {
            //Arange
            RepeatCounter newRepeatCounter = new RepeatCounter();
            string testWord = "To-Do";

            //Act
            string result = newRepeatCounter.StripPunctuation(testWord);

            //Assert
            Assert.AreEqual(result, "To-Do");
        }
    }
}
