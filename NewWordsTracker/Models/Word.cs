using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWordsTracker.Models
{
    internal class Word
    {
        public string Text { get; set; }
        public string Meaning { get; set; }
        public bool Learned { get; set; }
    }
}
