﻿namespace Calculator
{
    partial class MainCalc
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultBox = new System.Windows.Forms.TextBox();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplying = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Percent = new System.Windows.Forms.Button();
            this.btn_Root = new System.Windows.Forms.Button();
            this.btn_Power = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.Silver;
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resultBox.Font = new System.Drawing.Font("Comic Sans MS", 35F);
            this.resultBox.Location = new System.Drawing.Point(20, 12);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(399, 179);
            this.resultBox.TabIndex = 0;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultBox.Leave += new System.EventHandler(this.ReFocus);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDot.Location = new System.Drawing.Point(20, 439);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(75, 75);
            this.btnDot.TabIndex = 16;
            this.btnDot.Tag = ",";
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnClick);
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddition.Location = new System.Drawing.Point(263, 439);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 75);
            this.btnAddition.TabIndex = 19;
            this.btnAddition.Tag = "+";
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.Click += new System.EventHandler(this.btnClick);
            this.btnAddition.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btnAddition.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn9.Location = new System.Drawing.Point(182, 197);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 75);
            this.btn9.TabIndex = 3;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnClick);
            this.btn9.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn9.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn6.Location = new System.Drawing.Point(182, 278);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 75);
            this.btn6.TabIndex = 8;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnClick);
            this.btn6.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn6.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSubtraction.Location = new System.Drawing.Point(263, 358);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(75, 75);
            this.btnSubtraction.TabIndex = 14;
            this.btnSubtraction.Tag = "-";
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = false;
            this.btnSubtraction.Click += new System.EventHandler(this.btnClick);
            this.btnSubtraction.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btnSubtraction.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEqual.Location = new System.Drawing.Point(182, 439);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 75);
            this.btnEqual.TabIndex = 18;
            this.btnEqual.Tag = "=";
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnClick);
            this.btnEqual.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btnEqual.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn8.Location = new System.Drawing.Point(101, 197);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 75);
            this.btn8.TabIndex = 2;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnClick);
            this.btn8.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn8.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn5.Location = new System.Drawing.Point(101, 278);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 75);
            this.btn5.TabIndex = 7;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnClick);
            this.btn5.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn5.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn3.Location = new System.Drawing.Point(182, 358);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 75);
            this.btn3.TabIndex = 13;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnClick);
            this.btn3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn0.Location = new System.Drawing.Point(101, 439);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 75);
            this.btn0.TabIndex = 17;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnClick);
            this.btn0.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn0.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn7.Location = new System.Drawing.Point(20, 197);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 75);
            this.btn7.TabIndex = 1;
            this.btn7.TabStop = false;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnClick);
            this.btn7.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn7.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn4.Location = new System.Drawing.Point(20, 278);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 75);
            this.btn4.TabIndex = 6;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnClick);
            this.btn4.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn4.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn1.Location = new System.Drawing.Point(20, 358);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 75);
            this.btn1.TabIndex = 11;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnClick);
            this.btn1.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn1.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn2.Location = new System.Drawing.Point(101, 358);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 75);
            this.btn2.TabIndex = 12;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnClick);
            this.btn2.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn2.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDivision.Location = new System.Drawing.Point(263, 197);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 75);
            this.btnDivision.TabIndex = 4;
            this.btnDivision.Tag = "/";
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnClick);
            this.btnDivision.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btnDivision.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btnMultiplying
            // 
            this.btnMultiplying.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMultiplying.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMultiplying.Location = new System.Drawing.Point(263, 278);
            this.btnMultiplying.Name = "btnMultiplying";
            this.btnMultiplying.Size = new System.Drawing.Size(75, 75);
            this.btnMultiplying.TabIndex = 9;
            this.btnMultiplying.Tag = "*";
            this.btnMultiplying.Text = "*";
            this.btnMultiplying.UseVisualStyleBackColor = false;
            this.btnMultiplying.Click += new System.EventHandler(this.btnClick);
            this.btnMultiplying.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btnMultiplying.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Clear.Location = new System.Drawing.Point(344, 197);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 75);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Tag = "~";
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btnClick);
            this.btn_Clear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyboardKeyClick);
            this.btn_Clear.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn_Clear.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn_Percent
            // 
            this.btn_Percent.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Percent.Location = new System.Drawing.Point(344, 438);
            this.btn_Percent.Name = "btn_Percent";
            this.btn_Percent.Size = new System.Drawing.Size(75, 75);
            this.btn_Percent.TabIndex = 20;
            this.btn_Percent.Tag = "%";
            this.btn_Percent.Text = "%";
            this.btn_Percent.UseVisualStyleBackColor = false;
            this.btn_Percent.Click += new System.EventHandler(this.btnClick);
            this.btn_Percent.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn_Percent.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn_Root
            // 
            this.btn_Root.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Root.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Root.Location = new System.Drawing.Point(344, 358);
            this.btn_Root.Name = "btn_Root";
            this.btn_Root.Size = new System.Drawing.Size(75, 75);
            this.btn_Root.TabIndex = 15;
            this.btn_Root.Tag = "#";
            this.btn_Root.Text = "Sqrt";
            this.btn_Root.UseVisualStyleBackColor = false;
            this.btn_Root.Click += new System.EventHandler(this.btnClick);
            this.btn_Root.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn_Root.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // btn_Power
            // 
            this.btn_Power.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Power.Location = new System.Drawing.Point(344, 278);
            this.btn_Power.Name = "btn_Power";
            this.btn_Power.Size = new System.Drawing.Size(75, 75);
            this.btn_Power.TabIndex = 10;
            this.btn_Power.Tag = "^";
            this.btn_Power.Text = "Pow";
            this.btn_Power.UseVisualStyleBackColor = false;
            this.btn_Power.Click += new System.EventHandler(this.btnClick);
            this.btn_Power.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.btn_Power.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // MainCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(439, 525);
            this.Controls.Add(this.btn_Power);
            this.Controls.Add(this.btn_Root);
            this.Controls.Add(this.btn_Percent);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btnMultiplying);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.resultBox);
            this.MaximizeBox = false;
            this.Name = "MainCalc";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyboardKeyClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplying;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Percent;
        private System.Windows.Forms.Button btn_Root;
        private System.Windows.Forms.Button btn_Power;
    }
}

