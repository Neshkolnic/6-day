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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            { label2.Text = "Строка пустая"; }
            else
            { label2.Text = "Строка есть"; }
            Scet(textBox1.Text);

        }
        public string message;

        private void Scet(string str)
        {
            int symbols = 0, digits = 0, letters = 0;

            // Очистка DataGridView перед добавлением новых элементов
            dataGridView1.Rows.Clear();

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                string type;

                if (char.IsLetter(ch))
                {
                    letters++;
                    type = "Буква";
                }
                else if (char.IsDigit(ch))
                {
                    digits++;
                    type = "Цифра";
                }
                else if (char.IsSymbol(ch) || char.IsPunctuation(ch))
                {
                    symbols++;
                    type = "Знак";
                }
                else
                {
                    type = "Неопределенный символ";
                }

                // Добавление строки с данными в DataGridView
                dataGridView1.Rows.Add(ch.ToString(), type);
            }
             message = $"Букв: {letters}\nЦифр: {digits}\nЗнаков: {symbols}";
            //return message;
            // Вывод статистики
           // MessageBox.Show($"Букв: {letters}\nЦифр: {digits}\nЗнаков: {symbols}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(message);
            
        }

        private string sequence()
        { 
            string str = "";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = i; j <= 9; j++)
                {
                    str += j;
                }
            }
            return str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = sequence();
        }

        private void заданиеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 fmr = new Form2();
                fmr.ShowDialog();
        }

        private void заданиеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3 fmr = new Form3();
                fmr.ShowDialog();
        }

        private void заданиеToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form4 fmr = new Form4();
                fmr.ShowDialog();
        }
    }
}
