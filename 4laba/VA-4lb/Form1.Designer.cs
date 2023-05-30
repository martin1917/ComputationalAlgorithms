namespace VA_4lb
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.stepsInterval = new System.Windows.Forms.RichTextBox();
            this.ansInterval = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ansHalf = new System.Windows.Forms.TextBox();
            this.stepsHalf = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ansNewton = new System.Windows.Forms.TextBox();
            this.stepsNewton = new System.Windows.Forms.RichTextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.btnHalf = new System.Windows.Forms.Button();
            this.dtnNewton = new System.Windows.Forms.Button();
            this.btnInterval = new System.Windows.Forms.Button();
            this.errorSolve = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(549, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(608, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Уравнение";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(43, 103);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(45, 20);
            this.tbA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Укажите отрезок [A;B] и кол-во частей N,\r\nна которые разобьется отрезок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "A =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "N =";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(43, 145);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(45, 20);
            this.tbN.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Поиск интервала";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(107, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "B =";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(137, 103);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(45, 20);
            this.tbB.TabIndex = 2;
            // 
            // stepsInterval
            // 
            this.stepsInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepsInterval.Location = new System.Drawing.Point(12, 221);
            this.stepsInterval.Name = "stepsInterval";
            this.stepsInterval.ReadOnly = true;
            this.stepsInterval.Size = new System.Drawing.Size(229, 176);
            this.stepsInterval.TabIndex = 3;
            this.stepsInterval.Text = "";
            // 
            // ansInterval
            // 
            this.ansInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ansInterval.Location = new System.Drawing.Point(12, 446);
            this.ansInterval.Name = "ansInterval";
            this.ansInterval.ReadOnly = true;
            this.ansInterval.Size = new System.Drawing.Size(225, 22);
            this.ansInterval.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Шаги";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Интервал";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(374, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 40);
            this.label9.TabIndex = 1;
            this.label9.Text = "Уточнение корней методом\r\nполовинного деления ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(378, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Шаги";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(378, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ответ";
            // 
            // ansHalf
            // 
            this.ansHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ansHalf.Location = new System.Drawing.Point(378, 446);
            this.ansHalf.Name = "ansHalf";
            this.ansHalf.ReadOnly = true;
            this.ansHalf.Size = new System.Drawing.Size(225, 22);
            this.ansHalf.TabIndex = 2;
            // 
            // stepsHalf
            // 
            this.stepsHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepsHalf.Location = new System.Drawing.Point(378, 221);
            this.stepsHalf.Name = "stepsHalf";
            this.stepsHalf.ReadOnly = true;
            this.stepsHalf.Size = new System.Drawing.Size(229, 176);
            this.stepsHalf.TabIndex = 3;
            this.stepsHalf.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(709, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Шаги";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(709, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Ответ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(705, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(245, 40);
            this.label14.TabIndex = 1;
            this.label14.Text = "Уточнение корней методом\r\nНьютона";
            // 
            // ansNewton
            // 
            this.ansNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ansNewton.Location = new System.Drawing.Point(709, 446);
            this.ansNewton.Name = "ansNewton";
            this.ansNewton.ReadOnly = true;
            this.ansNewton.Size = new System.Drawing.Size(225, 22);
            this.ansNewton.TabIndex = 2;
            // 
            // stepsNewton
            // 
            this.stepsNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepsNewton.Location = new System.Drawing.Point(709, 221);
            this.stepsNewton.Name = "stepsNewton";
            this.stepsNewton.ReadOnly = true;
            this.stepsNewton.Size = new System.Drawing.Size(229, 176);
            this.stepsNewton.TabIndex = 3;
            this.stepsNewton.Text = "";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 176);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(80, 13);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "<error validate>";
            // 
            // btnHalf
            // 
            this.btnHalf.Location = new System.Drawing.Point(456, 118);
            this.btnHalf.Name = "btnHalf";
            this.btnHalf.Size = new System.Drawing.Size(75, 23);
            this.btnHalf.TabIndex = 5;
            this.btnHalf.Text = "Уточнить";
            this.btnHalf.UseVisualStyleBackColor = true;
            this.btnHalf.Click += new System.EventHandler(this.btnHalf_Click);
            // 
            // dtnNewton
            // 
            this.dtnNewton.Location = new System.Drawing.Point(794, 118);
            this.dtnNewton.Name = "dtnNewton";
            this.dtnNewton.Size = new System.Drawing.Size(75, 23);
            this.dtnNewton.TabIndex = 5;
            this.dtnNewton.Text = "Уточнить";
            this.dtnNewton.UseVisualStyleBackColor = true;
            this.dtnNewton.Click += new System.EventHandler(this.dtnNewton_Click);
            // 
            // btnInterval
            // 
            this.btnInterval.Location = new System.Drawing.Point(125, 146);
            this.btnInterval.Name = "btnInterval";
            this.btnInterval.Size = new System.Drawing.Size(75, 23);
            this.btnInterval.TabIndex = 5;
            this.btnInterval.Text = "Искать";
            this.btnInterval.UseVisualStyleBackColor = true;
            this.btnInterval.Click += new System.EventHandler(this.btnInterval_Click);
            // 
            // errorSolve
            // 
            this.errorSolve.AutoSize = true;
            this.errorSolve.ForeColor = System.Drawing.Color.Red;
            this.errorSolve.Location = new System.Drawing.Point(628, 86);
            this.errorSolve.Name = "errorSolve";
            this.errorSolve.Size = new System.Drawing.Size(67, 13);
            this.errorSolve.TabIndex = 4;
            this.errorSolve.Text = "<errorSolve>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 491);
            this.Controls.Add(this.dtnNewton);
            this.Controls.Add(this.btnInterval);
            this.Controls.Add(this.btnHalf);
            this.Controls.Add(this.errorSolve);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.stepsNewton);
            this.Controls.Add(this.stepsHalf);
            this.Controls.Add(this.stepsInterval);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.ansNewton);
            this.Controls.Add(this.ansHalf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ansInterval);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.RichTextBox stepsInterval;
        private System.Windows.Forms.TextBox ansInterval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ansHalf;
        private System.Windows.Forms.RichTextBox stepsHalf;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ansNewton;
        private System.Windows.Forms.RichTextBox stepsNewton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button btnHalf;
        private System.Windows.Forms.Button dtnNewton;
        private System.Windows.Forms.Button btnInterval;
        private System.Windows.Forms.Label errorSolve;
    }
}

