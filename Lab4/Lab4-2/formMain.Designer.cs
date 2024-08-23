namespace Lab4_2
{
    partial class formMain
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
            this.textContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.labelDisplay = new System.Windows.Forms.Label();
            this.comboContentAlignment = new System.Windows.Forms.ComboBox();
            this.comboBGColour = new System.Windows.Forms.ComboBox();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ข้อความ:";
            // 
            // textContent
            // 
            this.textContent.Location = new System.Drawing.Point(187, 27);
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(197, 29);
            this.textContent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "สีพื้นหลัง:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "การจัดตำแหน่งเนื้อหา:";
            // 
            // buttonAssign
            // 
            this.buttonAssign.Location = new System.Drawing.Point(118, 138);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(100, 34);
            this.buttonAssign.TabIndex = 3;
            this.buttonAssign.Text = "กำหนดค่า";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // labelDisplay
            // 
            this.labelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDisplay.Location = new System.Drawing.Point(12, 185);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(419, 81);
            this.labelDisplay.TabIndex = 4;
            // 
            // comboContentAlignment
            // 
            this.comboContentAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboContentAlignment.FormattingEnabled = true;
            this.comboContentAlignment.Location = new System.Drawing.Point(187, 100);
            this.comboContentAlignment.Name = "comboContentAlignment";
            this.comboContentAlignment.Size = new System.Drawing.Size(197, 32);
            this.comboContentAlignment.TabIndex = 5;
            // 
            // comboBGColour
            // 
            this.comboBGColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBGColour.FormattingEnabled = true;
            this.comboBGColour.Location = new System.Drawing.Point(187, 62);
            this.comboBGColour.Name = "comboBGColour";
            this.comboBGColour.Size = new System.Drawing.Size(197, 32);
            this.comboBGColour.TabIndex = 5;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(224, 138);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(100, 34);
            this.buttonDisplay.TabIndex = 3;
            this.buttonDisplay.Text = "แสดงผล";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 283);
            this.Controls.Add(this.comboBGColour);
            this.Controls.Add(this.comboContentAlignment);
            this.Controls.Add(this.labelDisplay);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonAssign);
            this.Controls.Add(this.textContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "formMain";
            this.Text = "การใช้งาน Structure และ Enum";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.ComboBox comboContentAlignment;
        private System.Windows.Forms.ComboBox comboBGColour;
        private System.Windows.Forms.Button buttonDisplay;
    }
}

