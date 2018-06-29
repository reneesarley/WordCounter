using System;
using WordCounter;

namespace WordCounter
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                RepeatCounter newRepeatCounter = new RepeatCounter();
                Console.WriteLine("Enter a word you would like to search for");
                //newRepeatCounter.GetUsersWord();
                string usersWord = Console.ReadLine();
                newRepeatCounter.SetWordToFind(usersWord);
                if (newRepeatCounter.VerifyJustOneWord())
                {
                    Console.WriteLine("Enter a string you'd like searched for your word and I'll tell you how many times the word appears.");
                    string usersString = Console.ReadLine();
                    newRepeatCounter.SetWordToFind(usersWord);
                    newRepeatCounter.SetStringToSearch(usersString);
                    newRepeatCounter.UpdateWordCounter();
                    int wordCount = newRepeatCounter.GetWordCounter();
                    Console.WriteLine("'{0}' appears {1} times in '{2}'", usersWord, wordCount, usersString);
                }
                else
                {
                    Console.WriteLine("Please only enter one word");
                }
            }
        }
    }
}
