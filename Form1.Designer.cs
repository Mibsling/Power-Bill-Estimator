namespace Lab1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblOption = new System.Windows.Forms.Label();
            this.Residential = new System.Windows.Forms.RadioButton();
            this.Commercial = new System.Windows.Forms.RadioButton();
            this.OffPeak = new System.Windows.Forms.RadioButton();
            this.PeakHours = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.Industrial = new System.Windows.Forms.RadioButton();
            this.Choose = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtInput.Location = new System.Drawing.Point(327, 226);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 26);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblWelcome.Location = new System.Drawing.Point(55, 128);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(733, 39);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to City Power Company Bill Estimator";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEnter.Location = new System.Drawing.Point(207, 174);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(354, 25);
            this.lblEnter.TabIndex = 2;
            this.lblEnter.Text = "Please Enter your Power Usage in kWh";
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblOption.Location = new System.Drawing.Point(508, 401);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(218, 25);
            this.lblOption.TabIndex = 3;
            this.lblOption.Text = "Choose type of account";
            // 
            // Residential
            // 
            this.Residential.AutoSize = true;
            this.Residential.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Residential.Location = new System.Drawing.Point(12, 90);
            this.Residential.Name = "Residential";
            this.Residential.Size = new System.Drawing.Size(167, 35);
            this.Residential.TabIndex = 4;
            this.Residential.TabStop = true;
            this.Residential.Text = "Residential";
            this.Residential.UseVisualStyleBackColor = true;
            this.Residential.CheckedChanged += new System.EventHandler(this.Residential_CheckedChanged);
            // 
            // Commercial
            // 
            this.Commercial.AutoSize = true;
            this.Commercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Commercial.Location = new System.Drawing.Point(185, 90);
            this.Commercial.Name = "Commercial";
            this.Commercial.Size = new System.Drawing.Size(176, 35);
            this.Commercial.TabIndex = 4;
            this.Commercial.TabStop = true;
            this.Commercial.Text = "Commercial";
            this.Commercial.UseVisualStyleBackColor = true;
            this.Commercial.CheckedChanged += new System.EventHandler(this.Commercial_CheckedChanged);
            // 
            // OffPeak
            // 
            this.OffPeak.AutoSize = true;
            this.OffPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OffPeak.Location = new System.Drawing.Point(457, 131);
            this.OffPeak.Name = "OffPeak";
            this.OffPeak.Size = new System.Drawing.Size(141, 24);
            this.OffPeak.TabIndex = 7;
            this.OffPeak.TabStop = true;
            this.OffPeak.Text = "Off-Peak  Hours";
            this.OffPeak.UseVisualStyleBackColor = true;
            // 
            // PeakHours
            // 
            this.PeakHours.AutoSize = true;
            this.PeakHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PeakHours.Location = new System.Drawing.Point(286, 131);
            this.PeakHours.Name = "PeakHours";
            this.PeakHours.Size = new System.Drawing.Size(110, 24);
            this.PeakHours.TabIndex = 8;
            this.PeakHours.TabStop = true;
            this.PeakHours.Text = "Peak Hours";
            this.PeakHours.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCalculate.Location = new System.Drawing.Point(212, 276);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(125, 38);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnClear.Location = new System.Drawing.Point(411, 276);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 38);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Output.Location = new System.Drawing.Point(290, 332);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 31);
            this.Output.TabIndex = 11;
            // 
            // Industrial
            // 
            this.Industrial.AutoSize = true;
            this.Industrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Industrial.Location = new System.Drawing.Point(367, 90);
            this.Industrial.Name = "Industrial";
            this.Industrial.Size = new System.Drawing.Size(143, 35);
            this.Industrial.TabIndex = 12;
            this.Industrial.TabStop = true;
            this.Industrial.Text = "Industrial";
            this.Industrial.UseVisualStyleBackColor = true;
            this.Industrial.CheckedChanged += new System.EventHandler(this.Industrial_CheckedChanged);
            // 
            // Choose
            // 
            this.Choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Choose.Location = new System.Drawing.Point(145, 184);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(440, 52);
            this.Choose.TabIndex = 13;
            this.Choose.Text = "Click to choose type of account";
            this.Choose.UseVisualStyleBackColor = true;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExit.Location = new System.Drawing.Point(341, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Choose);
            this.Controls.Add(this.Industrial);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.PeakHours);
            this.Controls.Add(this.OffPeak);
            this.Controls.Add(this.Commercial);
            this.Controls.Add(this.Residential);
            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.RadioButton Residential;
        private System.Windows.Forms.RadioButton Commercial;
        private System.Windows.Forms.RadioButton OffPeak;
        private System.Windows.Forms.RadioButton PeakHours;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.RadioButton Industrial;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.Button btnExit;
    }
}

