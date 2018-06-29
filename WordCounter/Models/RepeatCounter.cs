using System;
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

    }
}
