using Lib_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практ_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Class1 instance = new Class1();
            try
            {
                if (Convert.ToInt32(txtInput.Text) < 0)
                {
                    int limitNumber = Convert.ToInt32(txtInput.Text);
                    List<int> numbers = instance.CalculateTask(limitNumber, out int razn);
                    txtRazn.Text = razn.ToString();
                    txtNumbers.Clear();
                    foreach (int number in numbers)
                    {
                        txtNumbers.Text += number.ToString() + " ";
                    }
                    txtCount.Text = numbers.Count.ToString();
                }
                else MessageBox.Show("Введено значение больше 0");
            }

            catch (FormatException)
            {
                MessageBox.Show("Введеное знаечение не является числом");
            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Подъяблонский Данила\n" +
                "Студент группы ИСП-31\n" +
                "Практическая №1, Задание:\n" +
                "Расчитайте разницу случайных чисел в диапазоне от -2 до 10, пока разница этих чисел не будет больше определенного числа K");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Подъяблонский Данила\n" +
                "Студент группы ИСП-31\n" +
                "Практическая №1, Задание:\n" +
                "Расчитайте разницу случайных чисел в диапазоне от -2 до 10, пока разница этих чисел не будет больше определенного числа K");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}