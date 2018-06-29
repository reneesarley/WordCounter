using System;
using System.Collections.Generic;
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
            mainWord = mainWord.ToLower();
            wordToCompare = wordToCompare.ToLower();

            if (mainWord == wordToCompare)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public List<string> ConvertStringToList(string inputtedString)
        {
            List<string> wordsToCompare = new List<string>(inputtedString.Split(' '));

            return wordsToCompare;
        }

        public void UpdateWordCounter()
        {
            List<string> wordsToCompare = new List<string>();
            wordsToCompare = this.ConvertStringToList(_stringToSearch);
            for (int i = 0; i < wordsToCompare.Count; ++i)
            {
                _wordCounter = _wordCounter + (CompareWords(_wordToFind, wordsToCompare[i]));
            }
        }
    }
}
