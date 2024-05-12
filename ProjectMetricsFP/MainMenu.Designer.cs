namespace ProjectMetricsFP
{
    partial class MainMenu
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.madeByLabel = new System.Windows.Forms.Label();
            this.ufpLabel = new System.Windows.Forms.Label();
            this.diLabel = new System.Windows.Forms.Label();
            this.tcfLabel = new System.Windows.Forms.Label();
            this.sweLabel = new System.Windows.Forms.Label();
            this.ufpTextbox = new System.Windows.Forms.TextBox();
            this.diTextbox = new System.Windows.Forms.TextBox();
            this.tcfTextbox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.proceedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(218, 43);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(526, 60);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome To FP Calculator";
            // 
            // madeByLabel
            // 
            this.madeByLabel.AutoSize = true;
            this.madeByLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.madeByLabel.Location = new System.Drawing.Point(198, 524);
            this.madeByLabel.Name = "madeByLabel";
            this.madeByLabel.Size = new System.Drawing.Size(596, 23);
            this.madeByLabel.TabIndex = 1;
            this.madeByLabel.Text = "Made By: Ahmed Sameh, Ahmed Tarek, Aly Yehia, Fadi Magdi, Karim Chehab ";
            // 
            // ufpLabel
            // 
            this.ufpLabel.AutoSize = true;
            this.ufpLabel.Location = new System.Drawing.Point(327, 260);
            this.ufpLabel.Name = "ufpLabel";
            this.ufpLabel.Size = new System.Drawing.Size(34, 20);
            this.ufpLabel.TabIndex = 2;
            this.ufpLabel.Text = "UFP";
            // 
            // diLabel
            // 
            this.diLabel.AutoSize = true;
            this.diLabel.Location = new System.Drawing.Point(327, 313);
            this.diLabel.Name = "diLabel";
            this.diLabel.Size = new System.Drawing.Size(24, 20);
            this.diLabel.TabIndex = 3;
            this.diLabel.Text = "DI";
            // 
            // tcfLabel
            // 
            this.tcfLabel.AutoSize = true;
            this.tcfLabel.Location = new System.Drawing.Point(327, 369);
            this.tcfLabel.Name = "tcfLabel";
            this.tcfLabel.Size = new System.Drawing.Size(32, 20);
            this.tcfLabel.TabIndex = 4;
            this.tcfLabel.Text = "TCF";
            // 
            // sweLabel
            // 
            this.sweLabel.AutoSize = true;
            this.sweLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sweLabel.Location = new System.Drawing.Point(435, 565);
            this.sweLabel.Name = "sweLabel";
            this.sweLabel.Size = new System.Drawing.Size(53, 23);
            this.sweLabel.TabIndex = 5;
            this.sweLabel.Text = "SWE3";
            // 
            // ufpTextbox
            // 
            this.ufpTextbox.Location = new System.Drawing.Point(392, 256);
            this.ufpTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ufpTextbox.Name = "ufpTextbox";
            this.ufpTextbox.Size = new System.Drawing.Size(151, 27);
            this.ufpTextbox.TabIndex = 6;
            // 
            // diTextbox
            // 
            this.diTextbox.Location = new System.Drawing.Point(392, 309);
            this.diTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.diTextbox.Name = "diTextbox";
            this.diTextbox.Size = new System.Drawing.Size(151, 27);
            this.diTextbox.TabIndex = 7;
            // 
            // tcfTextbox
            // 
            this.tcfTextbox.Location = new System.Drawing.Point(392, 365);
            this.tcfTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcfTextbox.Name = "tcfTextbox";
            this.tcfTextbox.Size = new System.Drawing.Size(151, 27);
            this.tcfTextbox.TabIndex = 8;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.instructionLabel.Location = new System.Drawing.Point(115, 163);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(731, 28);
            this.instructionLabel.TabIndex = 9;
            this.instructionLabel.Text = "Please provide the following givens if you want to skip certain calculations:";
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(419, 449);
            this.proceedButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(86, 31);
            this.proceedButton.TabIndex = 10;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 600);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.tcfTextbox);
            this.Controls.Add(this.diTextbox);
            this.Controls.Add(this.ufpTextbox);
            this.Controls.Add(this.sweLabel);
            this.Controls.Add(this.tcfLabel);
            this.Controls.Add(this.diLabel);
            this.Controls.Add(this.ufpLabel);
            this.Controls.Add(this.madeByLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label welcomeLabel;
        private Label madeByLabel;
        private Label ufpLabel;
        private Label diLabel;
        private Label tcfLabel;
        private Label sweLabel;
        private TextBox ufpTextbox;
        private TextBox diTextbox;
        private TextBox tcfTextbox;
        private Label instructionLabel;
        private Button proceedButton;
    }
}