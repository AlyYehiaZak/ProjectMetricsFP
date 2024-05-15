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
            welcomeLabel = new Label();
            madeByLabel = new Label();
            ufpLabel = new Label();
            diLabel = new Label();
            tcfLabel = new Label();
            sweLabel = new Label();
            ufpTextbox = new TextBox();
            diTextbox = new TextBox();
            tcfTextbox = new TextBox();
            instructionLabel = new Label();
            proceedButton = new Button();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(127, 29);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(419, 47);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome To FP Calculator";
            // 
            // madeByLabel
            // 
            madeByLabel.AutoSize = true;
            madeByLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            madeByLabel.Location = new Point(109, 390);
            madeByLabel.Name = "madeByLabel";
            madeByLabel.Size = new Size(457, 17);
            madeByLabel.TabIndex = 1;
            madeByLabel.Text = "Made By: Ahmed Sameh, Ahmed Tarek, Aly Yehia, Fadi Magdi, Karim Chehab ";
            // 
            // ufpLabel
            // 
            ufpLabel.AutoSize = true;
            ufpLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ufpLabel.Location = new Point(215, 191);
            ufpLabel.Name = "ufpLabel";
            ufpLabel.Size = new Size(38, 21);
            ufpLabel.TabIndex = 2;
            ufpLabel.Text = "UFP";
            // 
            // diLabel
            // 
            diLabel.AutoSize = true;
            diLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            diLabel.Location = new Point(215, 231);
            diLabel.Name = "diLabel";
            diLabel.Size = new Size(25, 21);
            diLabel.TabIndex = 3;
            diLabel.Text = "DI";
            // 
            // tcfLabel
            // 
            tcfLabel.AutoSize = true;
            tcfLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tcfLabel.Location = new Point(215, 273);
            tcfLabel.Name = "tcfLabel";
            tcfLabel.Size = new Size(35, 21);
            tcfLabel.TabIndex = 4;
            tcfLabel.Text = "TCF";
            // 
            // sweLabel
            // 
            sweLabel.AutoSize = true;
            sweLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            sweLabel.Location = new Point(317, 421);
            sweLabel.Name = "sweLabel";
            sweLabel.Size = new Size(41, 17);
            sweLabel.TabIndex = 5;
            sweLabel.Text = "SWE3";
            // 
            // ufpTextbox
            // 
            ufpTextbox.Location = new Point(279, 189);
            ufpTextbox.Name = "ufpTextbox";
            ufpTextbox.Size = new Size(133, 23);
            ufpTextbox.TabIndex = 6;
            // 
            // diTextbox
            // 
            diTextbox.Location = new Point(279, 229);
            diTextbox.Name = "diTextbox";
            diTextbox.Size = new Size(133, 23);
            diTextbox.TabIndex = 7;
            // 
            // tcfTextbox
            // 
            tcfTextbox.Location = new Point(279, 271);
            tcfTextbox.Name = "tcfTextbox";
            tcfTextbox.Size = new Size(133, 23);
            tcfTextbox.TabIndex = 8;
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            instructionLabel.Location = new Point(37, 119);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(585, 21);
            instructionLabel.TabIndex = 9;
            instructionLabel.Text = "Please provide the following givens if you want to skip certain calculations:";
            // 
            // proceedButton
            // 
            proceedButton.Location = new Point(293, 333);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(96, 26);
            proceedButton.TabIndex = 10;
            proceedButton.Text = "Calculate FP";
            proceedButton.UseVisualStyleBackColor = true;
            proceedButton.Click += proceedButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 450);
            Controls.Add(proceedButton);
            Controls.Add(instructionLabel);
            Controls.Add(tcfTextbox);
            Controls.Add(diTextbox);
            Controls.Add(ufpTextbox);
            Controls.Add(sweLabel);
            Controls.Add(tcfLabel);
            Controls.Add(diLabel);
            Controls.Add(ufpLabel);
            Controls.Add(madeByLabel);
            Controls.Add(welcomeLabel);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
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