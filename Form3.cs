using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_day
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string input = textBox1.Text;
            char[] separators = { ' ', ',', '.' };
            int targetLength = int.Parse(textBox3.Text);
           // Console.WriteLine($"Слова, содержащие {targetLength} символов:");

            List<string> words = GetWordsWithLength(input, separators, targetLength);

            foreach (string word in words)
            {
                textBox2.AppendText(word + ' ');
            }
            string message = $"Количество слов: {words.Count}";
            MessageBox.Show(message);
        }
        static List<string> GetWordsWithLength(string input, char[] separators, int targetLength)
        {
            List<string> result = new List<string>();
            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (word.Length == targetLength)
                {
                    result.Add(word);
                }
            }

            return result;
        }
        static string TransformString(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (string word in input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries))
            {
                HashSet<char> seenChars = new HashSet<char>();
                foreach (char ch in word)
                {
                    if (!seenChars.Contains(ch))
                    {
                        result.Append(ch);
                        seenChars.Add(ch);
                    }
                }
                result.Append(" ");
            }

            if (result.Length > 0)
            {
                result.Length--; // Удаляем последний пробел
            }

            return result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            string input = textBox6.Text;
            string result = TransformString(input);
            textBox5.Text = result;
        }
    }
}
