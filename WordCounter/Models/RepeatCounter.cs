using System;
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

        public void UpdateWordCounter()
        {
            List<string> wordsToCompare = new List<string>();
            wordsToCompare = (new List<string>(_stringToSearch.Split(' ')));
            for (int i = 0; i < wordsToCompare.Count; ++i)
            {
                if (StripPunctuation(wordsToCompare[i].ToLower()) == _wordToFind.ToLower())
                {
                    _wordCounter = ++_wordCounter;
                }
            }
        }

        public string StripPunctuation(string word)
        {
            var noPunctuationString = new StringBuilder();
            for (int i = 0; i < word.Length; ++i)
            {
                if (!Char.IsPunctuation(word[i]) && i == word.Length - 1)
                {
                    noPunctuationString.Append(word[i]);
                }
                else if (i != word.Length - 1)
                {
                    noPunctuationString.Append(word[i]);
                }
            }
            return noPunctuationString.ToString();
        }
        public bool VerifyJustOneWord()
        {
            if(_wordToFind.Contains(" "))
            {
                return false;
            } else 
            {
                return true;
            }
        }
    }
}
