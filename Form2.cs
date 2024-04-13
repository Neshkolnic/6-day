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
    public partial class Form2 : Form

    {
        public Form2()
        {
            InitializeComponent();
        }


        static string RemoveEvenOccurrences(string str, char target)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == target)
                {
                    count++;
                    if (count % 2 == 0)
                    {
                        str = str.Remove(i, 1);
                        i--; // Уменьшаем индекс, чтобы не пропустить следующий символ
                    }
                }
            }
            return str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox3.Text.Length == 0)
                MessageBox.Show("Char hasn't been inputed!!!!");
            else
            {
                char target = char.Parse(textBox3.Text);
                textBox2.Text = RemoveEvenOccurrences(textBox1.Text, target);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = RemoveEvenLengthWords(textBox6.Text);
        }
        static string RemoveEvenLengthWords(string input)
        {
            StringBuilder result = new StringBuilder();
            string[] words = input.Split(' ');

            foreach (string word in words)
            {
                if (word.TrimEnd(',', '.').Length % 2 != 0)
                {
                    result.Append(word + " ");
                }
            }

            // Удаляем последний пробел и добавляем точку в конец строки
            result.Remove(result.Length - 1, 1) ;

            return result.ToString();
        }
    }
}
