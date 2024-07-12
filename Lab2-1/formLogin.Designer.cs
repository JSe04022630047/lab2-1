namespace Lab2_1
{
    partial class formLogin
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
            this.groupUserDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.groupGender = new System.Windows.Forms.GroupBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.groupTutorial = new System.Windows.Forms.GroupBox();
            this.checkCSharp = new System.Windows.Forms.CheckBox();
            this.checkPython = new System.Windows.Forms.CheckBox();
            this.checkASPNET = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listCity = new System.Windows.Forms.ListBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupUserDetails.SuspendLayout();
            this.groupGender.SuspendLayout();
            this.groupTutorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupUserDetails
            // 
            this.groupUserDetails.Controls.Add(this.textAddress);
            this.groupUserDetails.Controls.Add(this.textName);
            this.groupUserDetails.Controls.Add(this.label2);
            this.groupUserDetails.Controls.Add(this.label1);
            this.groupUserDetails.Location = new System.Drawing.Point(40, 27);
            this.groupUserDetails.Name = "groupUserDetails";
            this.groupUserDetails.Size = new System.Drawing.Size(748, 165);
            this.groupUserDetails.TabIndex = 0;
            this.groupUserDetails.TabStop = false;
            this.groupUserDetails.Text = "User Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(194, 42);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(521, 39);
            this.textName.TabIndex = 2;
            this.textName.Text = "Jirat Seawsirikul";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(194, 94);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(521, 39);
            this.textAddress.TabIndex = 2;
            this.textAddress.Text = "50/69";
            // 
            // groupGender
            // 
            this.groupGender.Controls.Add(this.radioFemale);
            this.groupGender.Controls.Add(this.radioMale);
            this.groupGender.Location = new System.Drawing.Point(813, 27);
            this.groupGender.Name = "groupGender";
            this.groupGender.Size = new System.Drawing.Size(280, 165);
            this.groupGender.TabIndex = 1;
            this.groupGender.TabStop = false;
            this.groupGender.Text = "Gender";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Checked = true;
            this.radioMale.Location = new System.Drawing.Point(43, 43);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(101, 36);
            this.radioMale.TabIndex = 0;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(43, 95);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(134, 36);
            this.radioFemale.TabIndex = 0;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // groupTutorial
            // 
            this.groupTutorial.Controls.Add(this.checkASPNET);
            this.groupTutorial.Controls.Add(this.checkPython);
            this.groupTutorial.Controls.Add(this.checkCSharp);
            this.groupTutorial.Location = new System.Drawing.Point(481, 207);
            this.groupTutorial.Name = "groupTutorial";
            this.groupTutorial.Size = new System.Drawing.Size(219, 202);
            this.groupTutorial.TabIndex = 2;
            this.groupTutorial.TabStop = false;
            this.groupTutorial.Text = "Tutorial";
            // 
            // checkCSharp
            // 
            this.checkCSharp.AutoSize = true;
            this.checkCSharp.Location = new System.Drawing.Point(25, 38);
            this.checkCSharp.Name = "checkCSharp";
            this.checkCSharp.Size = new System.Drawing.Size(76, 36);
            this.checkCSharp.TabIndex = 0;
            this.checkCSharp.Text = "C#";
            this.checkCSharp.UseVisualStyleBackColor = true;
            // 
            // checkPython
            // 
            this.checkPython.AutoSize = true;
            this.checkPython.Location = new System.Drawing.Point(25, 140);
            this.checkPython.Name = "checkPython";
            this.checkPython.Size = new System.Drawing.Size(129, 36);
            this.checkPython.TabIndex = 0;
            this.checkPython.Text = "Python";
            this.checkPython.UseVisualStyleBackColor = true;
            // 
            // checkASPNET
            // 
            this.checkASPNET.AutoSize = true;
            this.checkASPNET.Location = new System.Drawing.Point(25, 89);
            this.checkASPNET.Name = "checkASPNET";
            this.checkASPNET.Size = new System.Drawing.Size(161, 36);
            this.checkASPNET.TabIndex = 0;
            this.checkASPNET.Text = "ASP.NET";
            this.checkASPNET.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "City:";
            // 
            // listCity
            // 
            this.listCity.FormattingEnabled = true;
            this.listCity.ItemHeight = 32;
            this.listCity.Items.AddRange(new object[] {
            "Bangkok",
            "Nonthaburi",
            "Nakhon Pathom",
            "Samut Prakhram",
            "Samut Songkhram",
            "Samut Sakhon"});
            this.listCity.Location = new System.Drawing.Point(44, 245);
            this.listCity.Name = "listCity";
            this.listCity.Size = new System.Drawing.Size(421, 260);
            this.listCity.TabIndex = 4;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(481, 436);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(127, 49);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(628, 436);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(127, 49);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 517);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.listCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupTutorial);
            this.Controls.Add(this.groupGender);
            this.Controls.Add(this.groupUserDetails);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "formLogin";
            this.Text = "Login App";
            this.groupUserDetails.ResumeLayout(false);
            this.groupUserDetails.PerformLayout();
            this.groupGender.ResumeLayout(false);
            this.groupGender.PerformLayout();
            this.groupTutorial.ResumeLayout(false);
            this.groupTutorial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupUserDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.GroupBox groupGender;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.GroupBox groupTutorial;
        private System.Windows.Forms.CheckBox checkASPNET;
        private System.Windows.Forms.CheckBox checkPython;
        private System.Windows.Forms.CheckBox checkCSharp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listCity;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonExit;
    }
}

