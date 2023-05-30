using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
using System;
using System.Linq;

namespace VA2
{
    public partial class MainForm : Form
    {
        private static string RegexForInt { get; } = "^\\d{1,2}$";
        private static string RegexForDouble { get; } = "^(|-)\\d{1,5}(|[\\,\\.]\\d+)$";
        private static int countDigit { get; } = 8;

        private List<double> coefficientsNumerator = new List<double>();
        private List<double> coefficientsDenominator = new List<double>();

        public MainForm()
        {
            InitializeComponent();
            ClearSpecifiedFields();
            this.AutoScroll = true;
        }

        private void ClearSpecifiedFields()
        {
            errorNM.Text = "";
            errorX.Text = "";
            valueP.Text = "";
            valueQ.Text = "";
            labelAns.Text = "";
        }

        #region обработчики кнопок
        private void createP_Click(object sender, EventArgs e)
        {
            string nText = tbN.Text.Trim();
            if (!ValidateNM(nText)) return;
            coefficientsNumerator = GetCoefficients(int.Parse(nText));
            valueP.Text = GetFuncVM(coefficientsNumerator);
        }

        private void createQ_Click(object sender, EventArgs e)
        {
            string mText = tbM.Text.Trim();
            if (!ValidateNM(mText)) return;
            coefficientsDenominator = GetCoefficients(int.Parse(mText));
            valueQ.Text = GetFuncVM(coefficientsDenominator);
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (!ValidateX()) return;
            double x = double.Parse(tbX.Text.Trim().Replace('.', ','));

            var resSin = GetSin(x, countDigit);
            var resNumerator = GetAns(coefficientsNumerator, x, countDigit);
            var resDenominator = GetAns(coefficientsDenominator, x, countDigit);
            var result = Math.Sqrt(Math.E) / resSin - 2 * Math.Pow(resNumerator / resDenominator, 3);
            result = Math.Round(result, countDigit);

            labelAns.Text = result.ToString();
        }
        #endregion

        private List<double> GetCoefficients(int value)
        {
            CoefficientForm form1 = new CoefficientForm(value);
            form1.ShowDialog();
            return form1.Coefficients;
        }

        private string GetFuncVM(List<double> coefficients)
        {
            if (coefficients.Count == 0) return "";

            Dictionary<int, char> dict = new Dictionary<int, char>
            {
                {0, '\u2070' },
                {1, '\u00B9' },
                {2, '\u00B2' },
                {3, '\u00B3' },
                {4, '\u2074' },
                {5, '\u2075' },
                {6, '\u2076' },
                {7, '\u2077' },
                {8, '\u2078' },
                {9, '\u2079' },
            };

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < coefficients.Count - 1; i++)
            {
                if (coefficients[i] < 0)
                    sb.Append($"({coefficients[i]})");
                else
                    sb.Append($"{coefficients[i]}");

                var digits = (coefficients.Count - i - 1)
                    .ToString()
                    .ToCharArray()
                    .Select(d => dict[d - 48]);

                sb.Append($"•x{string.Concat(digits)}");
                sb.Append($" + ");
            }

            if (coefficients[coefficients.Count - 1] < 0)
                sb.Append($"({coefficients[coefficients.Count - 1]})");
            else
                sb.Append($"{coefficients[coefficients.Count - 1]}");

            return sb.ToString();
        }

        #region валидация разных полей
        private bool ValidateNM(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                errorNM.Text = "Значение N/M пусто";
                return false;
            }

            if (!Regex.IsMatch(text, RegexForInt))
            {
                errorNM.Text = "Значение N/M должно быть целым числом";
                return false;
            }

            int value = int.Parse(text);

            if (value < 1 || value > 20)
            {
                errorNM.Text = "Значение N/M должно находиться в [1; 20]";
                return false;
            }

            errorNM.Text = "";
            return true;
        }

        private bool ValidateX()
        {
            if (coefficientsNumerator.Count == 0 || coefficientsDenominator.Count == 0)
            {
                errorX.Text = "Вы не указали функции";
                return false;
            }

            string xText = tbX.Text.Trim();
            if (string.IsNullOrEmpty(xText))
            {
                errorX.Text = "Вы не указали значение для x";
                return false;
            }

            if (!Regex.IsMatch(xText, RegexForDouble))
            {
                errorX.Text = "Значение x должно быть действительным числом";
                return false;
            }

            errorX.Text = "";
            return true;
        }
        #endregion 

        #region Solve Functions
        private double GetSin(double x, int countDigit = 8)
        {
            double curr = Math.Round(x, countDigit + 1);
            double res = curr;

            int k = 1;
            while (Math.Abs(curr) >= Math.Pow(10, -countDigit))
            {
                curr *= (-1) * (x * x) / (2 * k * (2 * k + 1));
                curr = Math.Round(curr, countDigit + 1);
                res += curr;
                k++;
            }

            return Math.Round(res, countDigit);
        }

        private double GetAns(List<double> coefficients, double t, int countDigit = 8)
        {
            double p = coefficients[0];

            for (int i = 1; i < coefficients.Count; i++)
            {
                p = Math.Round(p * t + coefficients[i], countDigit);
            }

            return p;
        }
        #endregion
    }
}
