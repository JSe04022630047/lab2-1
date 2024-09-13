namespace Lab3_7
{
    partial class formRational
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSign = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.textC = new System.Windows.Forms.TextBox();
            this.textD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPlus = new System.Windows.Forms.RadioButton();
            this.radioMinus = new System.Windows.Forms.RadioButton();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "B";
            // 
            // labelSign
            // 
            this.labelSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSign.Location = new System.Drawing.Point(111, 34);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(32, 29);
            this.labelSign.TabIndex = 1;
            this.labelSign.Text = "*";
            this.labelSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "D";
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(43, 16);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(62, 29);
            this.textA.TabIndex = 2;
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(43, 55);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(62, 29);
            this.textB.TabIndex = 2;
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(169, 16);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(62, 29);
            this.textC.TabIndex = 2;
            // 
            // textD
            // 
            this.textD.Location = new System.Drawing.Point(169, 55);
            this.textD.Name = "textD";
            this.textD.Size = new System.Drawing.Size(62, 29);
            this.textD.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPlus);
            this.groupBox1.Controls.Add(this.radioMinus);
            this.groupBox1.Location = new System.Drawing.Point(4, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operators";
            // 
            // radioPlus
            // 
            this.radioPlus.AutoSize = true;
            this.radioPlus.Location = new System.Drawing.Point(28, 28);
            this.radioPlus.Name = "radioPlus";
            this.radioPlus.Size = new System.Drawing.Size(39, 28);
            this.radioPlus.TabIndex = 0;
            this.radioPlus.TabStop = true;
            this.radioPlus.Text = "+";
            this.radioPlus.UseVisualStyleBackColor = true;
            this.radioPlus.CheckedChanged += new System.EventHandler(this.radioPlus_CheckedChanged);
            // 
            // radioMinus
            // 
            this.radioMinus.AutoSize = true;
            this.radioMinus.Location = new System.Drawing.Point(82, 28);
            this.radioMinus.Name = "radioMinus";
            this.radioMinus.Size = new System.Drawing.Size(34, 28);
            this.radioMinus.TabIndex = 0;
            this.radioMinus.TabStop = true;
            this.radioMinus.Text = "-";
            this.radioMinus.UseVisualStyleBackColor = true;
            this.radioMinus.CheckedChanged += new System.EventHandler(this.radioMinus_CheckedChanged);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(153, 101);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(213, 56);
            this.buttonCalc.TabIndex = 4;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelResult
            // 
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Location = new System.Drawing.Point(237, 18);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(144, 66);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "ThisIsTwentyCharaters";
            // 
            // formRational
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 183);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.textD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "formRational";
            this.Text = "Rational Number";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.TextBox textD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMinus;
        private System.Windows.Forms.RadioButton radioPlus;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelResult;
    }
}

