namespace Hill_Mortgage2
{
    partial class MainFrm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.rad30year = new System.Windows.Forms.RadioButton();
            this.rad15Year = new System.Windows.Forms.RadioButton();
            this.lbl_interest = new System.Windows.Forms.Label();
            this.cboInterest = new System.Windows.Forms.ComboBox();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtOtherYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(45, 212);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 40);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(127, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(45, 166);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(157, 40);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Payment";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(57, 264);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(62, 13);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "placeholder";
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Location = new System.Drawing.Point(18, 115);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(60, 17);
            this.radOther.TabIndex = 4;
            this.radOther.TabStop = true;
            this.radOther.Text = "Other...";
            this.radOther.UseVisualStyleBackColor = true;
            this.radOther.CheckedChanged += new System.EventHandler(this.radOther_CheckedChanged);
            // 
            // rad30year
            // 
            this.rad30year.AutoSize = true;
            this.rad30year.Location = new System.Drawing.Point(18, 92);
            this.rad30year.Name = "rad30year";
            this.rad30year.Size = new System.Drawing.Size(62, 17);
            this.rad30year.TabIndex = 5;
            this.rad30year.TabStop = true;
            this.rad30year.Text = "30 Year";
            this.rad30year.UseVisualStyleBackColor = true;
            this.rad30year.CheckedChanged += new System.EventHandler(this.rad30year_CheckedChanged);
            // 
            // rad15Year
            // 
            this.rad15Year.AutoSize = true;
            this.rad15Year.Location = new System.Drawing.Point(18, 69);
            this.rad15Year.Name = "rad15Year";
            this.rad15Year.Size = new System.Drawing.Size(62, 17);
            this.rad15Year.TabIndex = 6;
            this.rad15Year.TabStop = true;
            this.rad15Year.Text = "15 Year";
            this.rad15Year.UseVisualStyleBackColor = true;
            this.rad15Year.CheckedChanged += new System.EventHandler(this.rad15Year_CheckedChanged);
            // 
            // lbl_interest
            // 
            this.lbl_interest.AutoSize = true;
            this.lbl_interest.Location = new System.Drawing.Point(18, 139);
            this.lbl_interest.Name = "lbl_interest";
            this.lbl_interest.Size = new System.Drawing.Size(42, 13);
            this.lbl_interest.TabIndex = 7;
            this.lbl_interest.Text = "Interest";
            // 
            // cboInterest
            // 
            this.cboInterest.FormattingEnabled = true;
            this.cboInterest.Items.AddRange(new object[] {
            "3.0",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4.0",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5"});
            this.cboInterest.Location = new System.Drawing.Point(60, 139);
            this.cboInterest.Name = "cboInterest";
            this.cboInterest.Size = new System.Drawing.Size(43, 21);
            this.cboInterest.TabIndex = 8;
            this.cboInterest.SelectedIndexChanged += new System.EventHandler(this.cboInterest_SelectedIndexChanged);
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(18, 47);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(72, 13);
            this.lblYears.TabIndex = 9;
            this.lblYears.Text = "Term in Years";
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(21, 20);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(50, 13);
            this.lblPrincipal.TabIndex = 10;
            this.lblPrincipal.Text = "Principal:";
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(77, 13);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtPrincipal.TabIndex = 11;
            // 
            // txtOtherYear
            // 
            this.txtOtherYear.Location = new System.Drawing.Point(77, 114);
            this.txtOtherYear.Name = "txtOtherYear";
            this.txtOtherYear.Size = new System.Drawing.Size(100, 20);
            this.txtOtherYear.TabIndex = 12;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 302);
            this.Controls.Add(this.txtOtherYear);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.cboInterest);
            this.Controls.Add(this.lbl_interest);
            this.Controls.Add(this.rad15Year);
            this.Controls.Add(this.rad30year);
            this.Controls.Add(this.radOther);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Name = "MainFrm";
            this.Text = "Riley Hill : Mortgage Calculator 2";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.RadioButton rad30year;
        private System.Windows.Forms.RadioButton rad15Year;
        private System.Windows.Forms.Label lbl_interest;
        private System.Windows.Forms.ComboBox cboInterest;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtOtherYear;
    }
}

