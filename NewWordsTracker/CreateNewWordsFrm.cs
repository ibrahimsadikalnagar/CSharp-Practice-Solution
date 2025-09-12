using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewWordsTracker.Services;

namespace NewWordsTracker
{
    public partial class CreateNewWordsFrm : Form
    {
        private WordManager manager = new WordManager();
        public CreateNewWordsFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBoxNewWord.Text;
            string meaning = textBoxMeaning.Text;
            if (!string.IsNullOrWhiteSpace(word) && !string.IsNullOrWhiteSpace(meaning))
            {

                manager.AddWord(word, meaning);
                UpdateWordList();
                textBoxNewWord.Clear();
                textBoxMeaning.Clear();
            }
            else
            {
                MessageBox.Show("Please enter both word and meaning.");
            } 
        }
        private void UpdateWordList()
        {
            listBoxNewWords.Items.Clear();
            foreach (var item in manager.GetAllWords())
            {
                listBoxNewWords.Items.Add($"{item.Text} - {item.Meaning}");
            }
        }
    }
}
