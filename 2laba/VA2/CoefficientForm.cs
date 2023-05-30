using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using System.Linq;
using System.Drawing;

namespace VA2
{
    public partial class CoefficientForm : Form
    {
        private static string RegexForDouble { get; } = "^(|-)\\d{1,5}(|[\\,\\.]\\d+)$";
        public List<double> Coefficients { get; } = new List<double>();
        private TableLayoutPanel tableLayoutPanel;

        public CoefficientForm(int n)
        {
            InitializeComponent();
            ClearSpecifiedFields();
            CreateTablePanel(n);
            this.AutoScroll = true;
        }

        private void ClearSpecifiedFields()
        {
            error.Text = "";
        }

        private void CreateTablePanel(int n)
        {
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

            tableLayoutPanel = new TableLayoutPanel
            {
                Parent = this,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                RowCount = 1,
                ColumnCount = 3 * n + 1
            };

            // styles
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
            for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }

            // x^n
            for (int j = 1, k = n; j <= tableLayoutPanel.ColumnCount - 2; j += 3, k--)
            {
                var digits = k.ToString()
                    .ToCharArray()
                    .Select(d => dict[d - 48]);

                Label label = createLabel($"x{string.Concat(digits)}");
                tableLayoutPanel.Controls.Add(label, j, 0);
            }

            // a, b, c, ...
            for (int j = 0; j <= tableLayoutPanel.ColumnCount; j += 3)
            {
                TextBox textBox = new TextBox { Width = 50 };
                textBox.BackColor = Color.FromArgb(255, 128, 128);
                textBox.Font = new Font("Times New Roman", 12.0f, FontStyle.Bold | FontStyle.Italic);
                textBox.TextChanged += CheckCorrect;
                tableLayoutPanel.Controls.Add(textBox, j, 0);
            }

            // +
            for (int j = 2; j <= tableLayoutPanel.ColumnCount - 1; j += 3)
            {
                Label label = createLabel("+");
                tableLayoutPanel.Controls.Add(label, j, 0);
            }
        }

        private Label createLabel(string text)
        {
            return new Label
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Width = 35,
                Font = new Font("Times New Roman", 14.0f, FontStyle.Bold | FontStyle.Italic)
            };
        }

        // визуализация корректности ввода
        private void CheckCorrect(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string coefficientText = textBox.Text.Trim();

            error.Text = "";

            for (int j = 0; j <= tableLayoutPanel.ColumnCount; j += 3)
            {
                if(!Regex.IsMatch(coefficientText, RegexForDouble))
                    textBox.BackColor = Color.FromArgb(255, 128, 128);
                else
                    textBox.BackColor = Color.White;
            }
        }

        // сохранение коэфициентов и закрытие формы
        private void btnOk_Click(object sender, EventArgs e)
        {
            for (int j = 0; j <= tableLayoutPanel.ColumnCount; j += 3)
            {
                TextBox textBox = tableLayoutPanel.GetControlFromPosition(j, 0) as TextBox;
                string coefficientText = textBox.Text.Trim();

                if (!Regex.IsMatch(coefficientText, RegexForDouble))
                {
                    error.Text = "Проверьте коэфициенты !!!";
                    return;
                }
            }

            for (int j = 0; j <= tableLayoutPanel.ColumnCount; j += 3)
            {
                TextBox textBox = tableLayoutPanel.GetControlFromPosition(j, 0) as TextBox;
                string coefficientText = textBox.Text.Trim();
                coefficientText = coefficientText.Replace('.', ',');
                Coefficients.Add(double.Parse(coefficientText));
            }

            this.Close();
        }
    }
}
