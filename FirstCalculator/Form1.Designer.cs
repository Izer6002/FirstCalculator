namespace FirstCalculator
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
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnClearEntry = new System.Windows.Forms.Button();
            this.TxtAnswer = new System.Windows.Forms.TextBox();
            this.LblOperation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMinus
            // 
            this.BtnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinus.Location = new System.Drawing.Point(470, 240);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(200, 100);
            this.BtnMinus.TabIndex = 1;
            this.BtnMinus.Text = "-";
            this.BtnMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.OperratorButton_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiply.Location = new System.Drawing.Point(470, 130);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(200, 100);
            this.BtnMultiply.TabIndex = 2;
            this.BtnMultiply.Text = "X";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.OperratorButton_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivide.Location = new System.Drawing.Point(470, 20);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(200, 100);
            this.BtnDivide.TabIndex = 3;
            this.BtnDivide.Text = "÷";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.OperratorButton_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlus.Location = new System.Drawing.Point(470, 350);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(200, 100);
            this.BtnPlus.TabIndex = 21;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.OperratorButton_Click);
            // 
            // BtnNine
            // 
            this.BtnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNine.Location = new System.Drawing.Point(310, 110);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(125, 75);
            this.BtnNine.TabIndex = 6;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = true;
            this.BtnNine.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // BtnEight
            // 
            this.BtnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEight.Location = new System.Drawing.Point(160, 110);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(125, 75);
            this.BtnEight.TabIndex = 5;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = true;
            this.BtnEight.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // BtnSeven
            // 
            this.BtnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeven.Location = new System.Drawing.Point(10, 110);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(125, 75);
            this.BtnSeven.TabIndex = 4;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = true;
            this.BtnSeven.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // BtnSix
            // 
            this.BtnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSix.Location = new System.Drawing.Point(310, 200);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(125, 75);
            this.BtnSix.TabIndex = 9;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = true;
            this.BtnSix.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // BtnFive
            // 
            this.BtnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFive.Location = new System.Drawing.Point(160, 200);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(125, 75);
            this.BtnFive.TabIndex = 8;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = true;
            this.BtnFive.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // BtnFour
            // 
            this.BtnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFour.Location = new System.Drawing.Point(10, 200);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(125, 75);
            this.BtnFour.TabIndex = 7;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = true;
            this.BtnFour.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // BtnThree
            // 
            this.BtnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThree.Location = new System.Drawing.Point(310, 290);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(125, 75);
            this.BtnThree.TabIndex = 10;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = true;
            this.BtnThree.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // BtnTwo
            // 
            this.BtnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTwo.Location = new System.Drawing.Point(160, 290);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(125, 75);
            this.BtnTwo.TabIndex = 11;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = true;
            this.BtnTwo.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // BtnOne
            // 
            this.BtnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOne.Location = new System.Drawing.Point(10, 290);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(125, 75);
            this.BtnOne.TabIndex = 12;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = true;
            this.BtnOne.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // BtnPoint
            // 
            this.BtnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPoint.Location = new System.Drawing.Point(310, 375);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(125, 75);
            this.BtnPoint.TabIndex = 14;
            this.BtnPoint.Text = ".";
            this.BtnPoint.UseVisualStyleBackColor = true;
            this.BtnPoint.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquals.Location = new System.Drawing.Point(700, 240);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(100, 210);
            this.BtnEquals.TabIndex = 15;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = true;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(700, 130);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(100, 100);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnClearEntry
            // 
            this.BtnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearEntry.Location = new System.Drawing.Point(700, 20);
            this.BtnClearEntry.Name = "BtnClearEntry";
            this.BtnClearEntry.Size = new System.Drawing.Size(100, 100);
            this.BtnClearEntry.TabIndex = 17;
            this.BtnClearEntry.Text = "CE";
            this.BtnClearEntry.UseVisualStyleBackColor = true;
            this.BtnClearEntry.Click += new System.EventHandler(this.BtnClearEntry_Click);
            // 
            // TxtAnswer
            // 
            this.TxtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnswer.Location = new System.Drawing.Point(10, 29);
            this.TxtAnswer.Multiline = true;
            this.TxtAnswer.Name = "TxtAnswer";
            this.TxtAnswer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtAnswer.Size = new System.Drawing.Size(425, 75);
            this.TxtAnswer.TabIndex = 18;
            this.TxtAnswer.Text = "0";
            this.TxtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblOperation
            // 
            this.LblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOperation.Location = new System.Drawing.Point(12, -2);
            this.LblOperation.Name = "LblOperation";
            this.LblOperation.Size = new System.Drawing.Size(140, 28);
            this.LblOperation.TabIndex = 19;
            this.LblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 75);
            this.button1.TabIndex = 22;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.LblOperation);
            this.Controls.Add(this.TxtAnswer);
            this.Controls.Add(this.BtnClearEntry);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnPoint);
            this.Controls.Add(this.BtnOne);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnThree);
            this.Controls.Add(this.BtnSix);
            this.Controls.Add(this.BtnFive);
            this.Controls.Add(this.BtnFour);
            this.Controls.Add(this.BtnNine);
            this.Controls.Add(this.BtnEight);
            this.Controls.Add(this.BtnSeven);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnMinus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnSeven;
        private System.Windows.Forms.Button BtnEight;
        private System.Windows.Forms.Button BtnNine;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Button BtnFive;
        private System.Windows.Forms.Button BtnSix;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnPoint;
        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnClearEntry;
        private System.Windows.Forms.TextBox TxtAnswer;
        private System.Windows.Forms.Label LblOperation;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button button1;
    }
}

