﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WordCounter
{
    public class RepeatCounter
    {
        private int _wordCounter;
        private string _wordToFind;
        private string _stringToSearch;

        public RepeatCounter()
        {
            _wordCounter = 0;
        }

        public int GetWordCounter()
        {
            return _wordCounter;
        }

        public void SetWordToFind(string inputtedWord)
        {
            _wordToFind = inputtedWord;
        }

        public string GetWordToFind()
        {
            return _wordToFind;
        }

        public void SetStringToSearch(string inputtedString)
        {
            _stringToSearch = inputtedString;
        }

        public string GetStringToSearch()
        {
            return _stringToSearch;
        }
        public int CompareWords(string mainWord, string wordToCompare)
        {
            if (StripPunctuation(wordToCompare.ToLower()) == mainWord.ToLower())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void UpdateWordCounter()
        {
            List<string> wordsToCompare = new List<string>();
            wordsToCompare = (new List<string>(_stringToSearch.Split(' ')));
            for (int i = 0; i < wordsToCompare.Count; ++i)
            {
                _wordCounter = _wordCounter + (CompareWords(_wordToFind, wordsToCompare[i]));
            }
        }

        public string StripPunctuation(string word)
        {
            var noPunctuationString = new StringBuilder();
            for (int i = 0; i < word.Length; ++i)
            {
                if (!Char.IsPunctuation(word[i]))
                {
                    noPunctuationString.Append(word[i]);
                }
            }
            return noPunctuationString.ToString();

        }
    }
}
