using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VA_laba_3.Gauss;
using System.Threading;

namespace VA_laba_3
{
    public partial class Form1 : Form
    {
        private static string RegexForInt { get; } = "^\\d{1,4}$";
        private LinearSystem linearSystem = null;
        private Algorithm alg = null;

        public Form1()
        {
            InitializeComponent();
            labelErr.Text = "";
        }

        private void tbCount_TextChanged(object sender, EventArgs e)
        {
            ValidateCountField();
        }

        private bool ValidateCountField()
        {
            string countText = tbCount.Text.Trim();

            if (string.IsNullOrEmpty(countText))
            {
                tbCount.BackColor = Color.FromArgb(255, 128, 128);
                labelErr.Text = "Кол-во не указано";
                return false;
            }

            if (!Regex.IsMatch(countText, RegexForInt))
            {
                tbCount.BackColor = Color.FromArgb(255, 128, 128);
                labelErr.Text = "Кол-во должно быть натуральным числом";
                return false;
            }

            int count = int.Parse(countText);

            if (count < 2)
            {
                tbCount.BackColor = Color.FromArgb(255, 128, 128);
                labelErr.Text = "Кол-во уравнений не менее 2";
                return false;
            }

            labelErr.Text = "";
            tbCount.BackColor = Color.White;
            return true;
        }

        private LinearSystem GenerateSystem(int size, int a, int b)
        {
            LinearSystem list = new LinearSystem();
            for (int i = 0; i < size; i++)
            {
                MyEquation eq = new MyEquation();
                eq.Generate(size + 1, a, b);
                Thread.Sleep(1);
                list.Push(eq);
            }
            return list;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!ValidateCountField()) return;

            int count = int.Parse(tbCount.Text);
            linearSystem = GenerateSystem(count, 0, 20);

            alg = new Algorithm(linearSystem);
            alg.DoAfterIteration += SystemToTextBox;

            rtbSystem.Text = linearSystem.ToString();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (linearSystem == null) return;
            double[] x = alg.Calculate();
            rtbAns.Text = AnsToTextBox(x);
        }

        private void SystemToTextBox(LinearSystem system, int step)
        {
            rtbSolution.Text += $"Шаг {step}\n{system}\n";
        }

        private string AnsToTextBox(double[] x)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < x.Length; i++)
            {
                sb.Append($"x{i} = {string.Format("{0:F2}", x[i])}; ");
            }
            return sb.ToString();
        }
    }
}
