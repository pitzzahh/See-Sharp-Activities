using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class GuessingGame : Form
    {
        private ArrayList WordsToGuess = new ArrayList();
        private ArrayList ScrambledWordsToGuess = new ArrayList();
        private ISet<int> GuessedWords = new HashSet<int>();
        private Random random = new Random();
        private int index = 0;
        private StringBuilder stringBuilder = new StringBuilder();
        public GuessingGame()
        {
            InitializeComponent();
            WordsToGuess.Add("HELLO");
            WordsToGuess.Add("WORLD");
            WordsToGuess.Add("PIZZA");
            WordsToGuess.Add("PINEAPPLE");
            WordsToGuess.Add("PETER");
            WordsToGuess.Add("JOHN");
            WordsToGuess.Add("SAN");

            foreach (string word in WordsToGuess)
            {
                int length = word.Length;
                int numCharsToReplace = random.Next(1, length);
                List<int> indicesToReplace = Enumerable.Range(0, length)
                    .OrderBy(x => random.Next())
                    .Take(numCharsToReplace)
                    .ToList();
                string scrambledWord = string.Concat(word.Select((c, i) => indicesToReplace.Contains(i) ? '?' : c));
                ScrambledWordsToGuess.Add(scrambledWord);
            }

            foreach (var s in ScrambledWordsToGuess)
            {
                Console.WriteLine(s);
            }
            index = random.Next(WordsToGuess.Count);
            Word.Text = ScrambledWordsToGuess[index].ToString();
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            if (GuessedWord.Text.ToString().ToLower().Equals(WordsToGuess[index].ToString().ToLower()))
            {
                MessageBox.Show("Correct guess");
                GuessedWords.Add(index);
                generateNewIndex();
                Word.Text = ScrambledWordsToGuess[index].ToString();
            }
            else
            {
                MessageBox.Show("Wrong guess!\nTry again");
                stringBuilder.AppendLine(GuessedWord.Text.ToString().Length == 0 ? "<Blank Input>" : GuessedWord.Text.ToString());
                wrongGuesses.Text = stringBuilder.ToString();
            }
            GuessedWord.Clear();
        }

        private void generateNewIndex()
        {
            while(GuessedWords.Contains(index))
            {
                index = random.Next(WordsToGuess.Count);
            }
        }
    }
}
