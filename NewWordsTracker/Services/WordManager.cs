using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewWordsTracker.Models;

namespace NewWordsTracker.Services
{
    internal class WordManager
    {
        private List<Word> words = new List<Word>();
        public void AddWord(string text , string meaning)
        {
            words.Add(new Word { Text = text, Meaning = meaning, Learned = false });
        }

        public List<Word> GetAllWords()
        {
            return words;
        }
    }
}
