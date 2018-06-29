using System;
using WordCounter;

namespace WordCounter
{
    class Program
    {
        static void Main()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter();
            Console.WriteLine("Enter a word you would like to search for");
            string usersWord = Console.ReadLine();
            Console.WriteLine("Enter a string you'd like searched for your word and I'll tell you how many times the word appears.");
            string userString = Console.ReadLine();
            newRepeatCounter.SetWordToFind(usersWord);
            newRepeatCounter.SetStringToSearch(userString);
            newRepeatCounter.UpdateWordCounter();
            int wordCount = newRepeatCounter.GetWordCounter();
            Console.WriteLine(wordCount);
            ///this is a test 

        }
    }
}
