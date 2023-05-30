namespace VA2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createP = new System.Windows.Forms.Button();
            this.createQ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAns = new System.Windows.Forms.Label();
            this.valueP = new System.Windows.Forms.Label();
            this.valueQ = new System.Windows.Forms.Label();
            this.errorNM = new System.Windows.Forms.Label();
            this.errorX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VA2.Properties.Resources.Функция;
            this.pictureBox1.Location = new System.Drawing.Point(16, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Функция:";
            // 
            // createP
            // 
            this.createP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createP.Location = new System.Drawing.Point(309, 32);
            this.createP.Name = "createP";
            this.createP.Size = new System.Drawing.Size(108, 29);
            this.createP.TabIndex = 2;
            this.createP.Text = "Задать P(t)";
            this.createP.UseVisualStyleBackColor = true;
            this.createP.Click += new System.EventHandler(this.createP_Click);
            // 
            // createQ
            // 
            this.createQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createQ.Location = new System.Drawing.Point(309, 81);
            this.createQ.Name = "createQ";
            this.createQ.Size = new System.Drawing.Size(108, 29);
            this.createQ.TabIndex = 2;
            this.createQ.Text = "Задать Q(t)";
            this.createQ.UseVisualStyleBackColor = true;
            this.createQ.Click += new System.EventHandler(this.createQ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(432, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "для n  = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(432, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "для m = ";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(505, 36);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(56, 20);
            this.tbN.TabIndex = 4;
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(505, 85);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(56, 20);
            this.tbM.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "P(t) = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Q(t) = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "x  = ";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(63, 236);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(56, 20);
            this.tbX.TabIndex = 4;
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSolve.Location = new System.Drawing.Point(162, 230);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(108, 29);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Решить";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(24, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ответ: ";
            // 
            // labelAns
            // 
            this.labelAns.AutoSize = true;
            this.labelAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAns.Location = new System.Drawing.Point(95, 294);
            this.labelAns.Name = "labelAns";
            this.labelAns.Size = new System.Drawing.Size(53, 20);
            this.labelAns.TabIndex = 5;
            this.labelAns.Text = "<ans>";
            // 
            // valueP
            // 
            this.valueP.AutoSize = true;
            this.valueP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueP.Location = new System.Drawing.Point(81, 160);
            this.valueP.Name = "valueP";
            this.valueP.Size = new System.Drawing.Size(64, 20);
            this.valueP.TabIndex = 5;
            this.valueP.Text = "<value>";
            // 
            // valueQ
            // 
            this.valueQ.AutoSize = true;
            this.valueQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueQ.Location = new System.Drawing.Point(81, 197);
            this.valueQ.Name = "valueQ";
            this.valueQ.Size = new System.Drawing.Size(64, 20);
            this.valueQ.TabIndex = 5;
            this.valueQ.Text = "<value>";
            // 
            // errorNM
            // 
            this.errorNM.AutoSize = true;
            this.errorNM.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorNM.Location = new System.Drawing.Point(16, 125);
            this.errorNM.Name = "errorNM";
            this.errorNM.Size = new System.Drawing.Size(61, 13);
            this.errorNM.TabIndex = 6;
            this.errorNM.Text = "<message>";
            // 
            // errorX
            // 
            this.errorX.AutoSize = true;
            this.errorX.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorX.Location = new System.Drawing.Point(24, 266);
            this.errorX.Name = "errorX";
            this.errorX.Size = new System.Drawing.Size(61, 13);
            this.errorX.TabIndex = 6;
            this.errorX.Text = "<message>";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 334);
            this.Controls.Add(this.errorX);
            this.Controls.Add(this.errorNM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.valueQ);
            this.Controls.Add(this.valueP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createQ);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.createP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Лаба 2 (Левин, Колягин)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createP;
        private System.Windows.Forms.Button createQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAns;
        private System.Windows.Forms.Label valueP;
        private System.Windows.Forms.Label valueQ;
        private System.Windows.Forms.Label errorNM;
        private System.Windows.Forms.Label errorX;
    }
}