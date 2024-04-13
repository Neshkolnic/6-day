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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        static string GetFirstNLowerCaseLetters(int N)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                char letter = (char)('a' + i);
                result.Append(letter);
            }

            return result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = GetFirstNLowerCaseLetters((int)numericUpDown1.Value);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ContainsCharacters(textBox6.Text, textBox5.Text))
            { textBox1.Text = "Входят все символы"; }
            else { textBox1.Text = "Не входят все символы"; }
            ;
        }

        private bool ContainsCharacters(string str1, string str2)
        {
            char current;
            int result = 0;
            for(int i = 0; i<=str2.Length-1; i++)
            {
                current = str2[i];
                if (str1.Contains(current))
                    result++;

            }

            return (str2.Length == result);
            
        }
    }
}
