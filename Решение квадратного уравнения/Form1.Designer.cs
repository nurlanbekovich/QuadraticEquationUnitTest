namespace Решение_квадратного_уравнения
{
    partial class Form1
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
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.X1Result = new System.Windows.Forms.Label();
            this.X2Result = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cleanTextBoxButton = new System.Windows.Forms.Button();
            this.findSolutionButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.discResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ATextBox
            // 
            this.ATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ATextBox.Location = new System.Drawing.Point(0, 137);
            this.ATextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(112, 32);
            this.ATextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(80, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(260, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "b";
            // 
            // BTextBox
            // 
            this.BTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTextBox.Location = new System.Drawing.Point(200, 138);
            this.BTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(112, 32);
            this.BTextBox.TabIndex = 2;
            // 
            // CTextBox
            // 
            this.CTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CTextBox.Location = new System.Drawing.Point(369, 138);
            this.CTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(112, 32);
            this.CTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(407, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "c";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(53, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "X1=";
            // 
            // X1Result
            // 
            this.X1Result.AutoSize = true;
            this.X1Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X1Result.Location = new System.Drawing.Point(114, 45);
            this.X1Result.Name = "X1Result";
            this.X1Result.Size = new System.Drawing.Size(18, 26);
            this.X1Result.TabIndex = 9;
            this.X1Result.Text = " ";
            // 
            // X2Result
            // 
            this.X2Result.AutoSize = true;
            this.X2Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X2Result.Location = new System.Drawing.Point(411, 45);
            this.X2Result.Name = "X2Result";
            this.X2Result.Size = new System.Drawing.Size(18, 26);
            this.X2Result.TabIndex = 11;
            this.X2Result.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(363, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "X2=";
            // 
            // cleanTextBoxButton
            // 
            this.cleanTextBoxButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cleanTextBoxButton.Location = new System.Drawing.Point(501, 190);
            this.cleanTextBoxButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cleanTextBoxButton.Name = "cleanTextBoxButton";
            this.cleanTextBoxButton.Size = new System.Drawing.Size(180, 49);
            this.cleanTextBoxButton.TabIndex = 12;
            this.cleanTextBoxButton.Text = "Очистить форму";
            this.cleanTextBoxButton.UseVisualStyleBackColor = true;
            this.cleanTextBoxButton.Click += new System.EventHandler(this.cleanTextBoxButton_Click);
            // 
            // findSolutionButton
            // 
            this.findSolutionButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.findSolutionButton.Location = new System.Drawing.Point(501, 123);
            this.findSolutionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findSolutionButton.Name = "findSolutionButton";
            this.findSolutionButton.Size = new System.Drawing.Size(180, 49);
            this.findSolutionButton.TabIndex = 6;
            this.findSolutionButton.Text = "Найти корни";
            this.findSolutionButton.UseVisualStyleBackColor = true;
            this.findSolutionButton.Click += new System.EventHandler(this.findSolutionButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(155, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дискриминант=";
            // 
            // discResult
            // 
            this.discResult.AutoSize = true;
            this.discResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discResult.Location = new System.Drawing.Point(335, 6);
            this.discResult.Name = "discResult";
            this.discResult.Size = new System.Drawing.Size(18, 26);
            this.discResult.TabIndex = 15;
            this.discResult.Text = " ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.discResult);
            this.panel1.Controls.Add(this.X2Result);
            this.panel1.Controls.Add(this.X1Result);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 100);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(114, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "X^2+";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(313, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "X+";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(693, 262);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cleanTextBoxButton);
            this.Controls.Add(this.findSolutionButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ATextBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Нахождение корней квадратного уравнения";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.TextBox CTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label X1Result;
        private System.Windows.Forms.Label X2Result;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cleanTextBoxButton;
        private System.Windows.Forms.Button findSolutionButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label discResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

