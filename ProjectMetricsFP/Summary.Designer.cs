namespace ProjectMetricsFP
{
    partial class Summary
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
            summaryTitle = new Label();
            tcfTextbox = new TextBox();
            diTextbox = new TextBox();
            ufpTextbox = new TextBox();
            tcfLabel = new Label();
            diLabel = new Label();
            ufpLabel = new Label();
            locTextbox = new TextBox();
            fpTextbox = new TextBox();
            locLabel = new Label();
            fpLabel = new Label();
            avcLabel = new Label();
            avcCombobox = new ComboBox();
            SuspendLayout();
            // 
            // summaryTitle
            // 
            summaryTitle.AutoSize = true;
            summaryTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            summaryTitle.Location = new Point(88, 21);
            summaryTitle.Name = "summaryTitle";
            summaryTitle.Size = new Size(399, 32);
            summaryTitle.TabIndex = 0;
            summaryTitle.Text = "Summary For All The Calculations";
            // 
            // tcfTextbox
            // 
            tcfTextbox.Location = new Point(231, 163);
            tcfTextbox.Name = "tcfTextbox";
            tcfTextbox.Size = new Size(133, 23);
            tcfTextbox.TabIndex = 14;
            // 
            // diTextbox
            // 
            diTextbox.Location = new Point(231, 126);
            diTextbox.Name = "diTextbox";
            diTextbox.Size = new Size(133, 23);
            diTextbox.TabIndex = 13;
            // 
            // ufpTextbox
            // 
            ufpTextbox.Location = new Point(231, 86);
            ufpTextbox.Name = "ufpTextbox";
            ufpTextbox.Size = new Size(133, 23);
            ufpTextbox.TabIndex = 12;
            // 
            // tcfLabel
            // 
            tcfLabel.AutoSize = true;
            tcfLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tcfLabel.Location = new Point(161, 166);
            tcfLabel.Name = "tcfLabel";
            tcfLabel.Size = new Size(35, 21);
            tcfLabel.TabIndex = 11;
            tcfLabel.Text = "TCF";
            // 
            // diLabel
            // 
            diLabel.AutoSize = true;
            diLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            diLabel.Location = new Point(161, 124);
            diLabel.Name = "diLabel";
            diLabel.Size = new Size(25, 21);
            diLabel.TabIndex = 10;
            diLabel.Text = "DI";
            // 
            // ufpLabel
            // 
            ufpLabel.AutoSize = true;
            ufpLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ufpLabel.Location = new Point(161, 84);
            ufpLabel.Name = "ufpLabel";
            ufpLabel.Size = new Size(38, 21);
            ufpLabel.TabIndex = 9;
            ufpLabel.Text = "UFP";
            // 
            // locTextbox
            // 
            locTextbox.Location = new Point(231, 310);
            locTextbox.Name = "locTextbox";
            locTextbox.Size = new Size(133, 23);
            locTextbox.TabIndex = 18;
            // 
            // fpTextbox
            // 
            fpTextbox.Location = new Point(231, 204);
            fpTextbox.Name = "fpTextbox";
            fpTextbox.Size = new Size(133, 23);
            fpTextbox.TabIndex = 17;
            // 
            // locLabel
            // 
            locLabel.AutoSize = true;
            locLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            locLabel.Location = new Point(157, 308);
            locLabel.Name = "locLabel";
            locLabel.Size = new Size(39, 21);
            locLabel.TabIndex = 16;
            locLabel.Text = "LOC";
            // 
            // fpLabel
            // 
            fpLabel.AutoSize = true;
            fpLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fpLabel.Location = new Point(161, 207);
            fpLabel.Name = "fpLabel";
            fpLabel.Size = new Size(27, 21);
            fpLabel.TabIndex = 15;
            fpLabel.Text = "FP";
            // 
            // avcLabel
            // 
            avcLabel.AutoSize = true;
            avcLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            avcLabel.Location = new Point(45, 261);
            avcLabel.Name = "avcLabel";
            avcLabel.Size = new Size(373, 21);
            avcLabel.TabIndex = 19;
            avcLabel.Text = "Please Select Your Code Language To Calculate LOC :";
            // 
            // avcCombobox
            // 
            avcCombobox.FormattingEnabled = true;
            avcCombobox.Location = new Point(424, 259);
            avcCombobox.Name = "avcCombobox";
            avcCombobox.Size = new Size(121, 23);
            avcCombobox.TabIndex = 20;
            avcCombobox.SelectedIndexChanged += avcCombobox_SelectedIndexChanged;
            // 
            // Summary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 383);
            Controls.Add(avcCombobox);
            Controls.Add(avcLabel);
            Controls.Add(locTextbox);
            Controls.Add(fpTextbox);
            Controls.Add(locLabel);
            Controls.Add(fpLabel);
            Controls.Add(tcfTextbox);
            Controls.Add(diTextbox);
            Controls.Add(ufpTextbox);
            Controls.Add(tcfLabel);
            Controls.Add(diLabel);
            Controls.Add(ufpLabel);
            Controls.Add(summaryTitle);
            Name = "Summary";
            Text = "Summary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label summaryTitle;
        private TextBox tcfTextbox;
        private TextBox diTextbox;
        private TextBox ufpTextbox;
        private Label tcfLabel;
        private Label diLabel;
        private Label ufpLabel;
        private TextBox locTextbox;
        private TextBox fpTextbox;
        private Label locLabel;
        private Label fpLabel;
        private Label avcLabel;
        private ComboBox avcCombobox;
    }
}