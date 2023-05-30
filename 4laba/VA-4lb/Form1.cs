using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VA_4lb
{
    public partial class Form1 : Form
    {
        private static string regexForInt = "^\\d{1,5}$";
        private static string regexForDouble = "^(|-)\\d{1,5}(|[\\,\\.]\\d+)$";

        private readonly Solver solver = new Solver();
        private (double a, double b)? interval = null;

        public Form1()
        {
            InitializeComponent();
            SettingsForOutput();
            errorLabel.Text = "";
            errorSolve.Text = "";
        }

        private void SettingsForOutput()
        {
            solver.DoAfterStepOnRootBranches += ((double x, double y) A) =>
            {
                stepsInterval.AppendText($"{string.Format("x: {0:F4}  y: {1:F4}", A.x, A.y)}\n");
            };

            solver.DoAfterStepOnHalfDivision += ((double x, double y) left, (double x, double y) middle, (double x, double y) right) =>
            {
                stepsHalf.AppendText($"A - {string.Format("(x: {0:F4}  y: {1:F4})", left.x, left.y)}\n");
                stepsHalf.AppendText($"X - {string.Format("(x: {0:F4}  y: {1:F4})", middle.x, middle.y)}\n");
                stepsHalf.AppendText($"B - {string.Format("(x: {0:F4}  y: {1:F4})", right.x, right.y)}\n");
                stepsHalf.AppendText($"\n");
            };

            solver.DoAfterStepOnNewtonsMethod += (prev, x) =>
            {
                stepsNewton.AppendText($"{string.Format("prev: {0:F4}  x: {1:F4}", prev, x)}\n");
            };
        }

        private void btnInterval_Click(object sender, EventArgs e)
        {
            string aText = tbA.Text.Trim();
            string bText = tbB.Text.Trim();
            string nText = tbN.Text.Trim();

            if (string.IsNullOrEmpty(aText) || string.IsNullOrEmpty(bText) || string.IsNullOrEmpty(nText))
            {
                errorLabel.Text = "Вы заполнили не все поля !!!";
                return;
            }

            if (!Regex.IsMatch(aText, regexForDouble) || !Regex.IsMatch(bText, regexForDouble))
            { 
                errorLabel.Text = "Границы отрезка должны быть действительными числами";
                return;
            }

            if (!Regex.IsMatch(nText, regexForInt))
            { 
                errorLabel.Text = "Кол-во отрезков должны быть целым неотрицательным числом";
                return;
            }

            ansInterval.Clear();
            errorLabel.Text = "";

            double a = double.Parse(aText, CultureInfo.InvariantCulture);
            double b = double.Parse(bText, CultureInfo.InvariantCulture);
            int n = int.Parse(nText, CultureInfo.InvariantCulture);

            interval = solver.RootBranches(a, b, n);
            ansInterval.Text = $"(a: {string.Format("{0:F4}", interval.Value.a)}; b: {string.Format("{0:F4}", interval.Value.b)})";
        }

        private void btnHalf_Click(object sender, EventArgs e)
        {
            if (interval is null)
            {
                errorSolve.Text = "Сначала необходимо найти интервал !!!";
                return;
            }

            ansHalf.Clear();
            errorSolve.Text = "";

            double ans = solver.HalfDivision(interval.GetValueOrDefault());
            ansHalf.Text = $"{ans}";
        }

        private void dtnNewton_Click(object sender, EventArgs e)
        {
            if (interval is null)
            {
                errorSolve.Text = "Сначала необходимо найти интервал !!!";
                return;
            }

            ansNewton.Clear();
            errorSolve.Text = "";

            double ans = solver.NewtonsMethod(interval.GetValueOrDefault());
            ansNewton.Text = $"{ans}";
        }
    }
}
