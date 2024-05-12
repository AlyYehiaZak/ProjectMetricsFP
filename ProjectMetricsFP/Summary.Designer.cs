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
            summaryTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            summaryTitle.Location = new Point(60, 30);
            summaryTitle.Name = "summaryTitle";
            summaryTitle.Size = new Size(301, 25);
            summaryTitle.TabIndex = 0;
            summaryTitle.Text = "Summary For All The Calculations";
            // 
            // tcfTextbox
            // 
            tcfTextbox.Location = new Point(127, 165);
            tcfTextbox.Name = "tcfTextbox";
            tcfTextbox.Size = new Size(133, 23);
            tcfTextbox.TabIndex = 14;
            // 
            // diTextbox
            // 
            diTextbox.Location = new Point(127, 128);
            diTextbox.Name = "diTextbox";
            diTextbox.Size = new Size(133, 23);
            diTextbox.TabIndex = 13;
            // 
            // ufpTextbox
            // 
            ufpTextbox.Location = new Point(127, 88);
            ufpTextbox.Name = "ufpTextbox";
            ufpTextbox.Size = new Size(133, 23);
            ufpTextbox.TabIndex = 12;
            // 
            // tcfLabel
            // 
            tcfLabel.AutoSize = true;
            tcfLabel.Location = new Point(60, 173);
            tcfLabel.Name = "tcfLabel";
            tcfLabel.Size = new Size(26, 15);
            tcfLabel.TabIndex = 11;
            tcfLabel.Text = "TCF";
            // 
            // diLabel
            // 
            diLabel.AutoSize = true;
            diLabel.Location = new Point(60, 131);
            diLabel.Name = "diLabel";
            diLabel.Size = new Size(18, 15);
            diLabel.TabIndex = 10;
            diLabel.Text = "DI";
            // 
            // ufpLabel
            // 
            ufpLabel.AutoSize = true;
            ufpLabel.Location = new Point(60, 91);
            ufpLabel.Name = "ufpLabel";
            ufpLabel.Size = new Size(28, 15);
            ufpLabel.TabIndex = 9;
            ufpLabel.Text = "UFP";
            // 
            // locTextbox
            // 
            locTextbox.Location = new Point(120, 304);
            locTextbox.Name = "locTextbox";
            locTextbox.Size = new Size(133, 23);
            locTextbox.TabIndex = 18;
            // 
            // fpTextbox
            // 
            fpTextbox.Location = new Point(127, 206);
            fpTextbox.Name = "fpTextbox";
            fpTextbox.Size = new Size(133, 23);
            fpTextbox.TabIndex = 17;
            // 
            // locLabel
            // 
            locLabel.AutoSize = true;
            locLabel.Location = new Point(60, 307);
            locLabel.Name = "locLabel";
            locLabel.Size = new Size(30, 15);
            locLabel.TabIndex = 16;
            locLabel.Text = "LOC";
            // 
            // fpLabel
            // 
            fpLabel.AutoSize = true;
            fpLabel.Location = new Point(60, 214);
            fpLabel.Name = "fpLabel";
            fpLabel.Size = new Size(20, 15);
            fpLabel.TabIndex = 15;
            fpLabel.Text = "FP";
            // 
            // avcLabel
            // 
            avcLabel.AutoSize = true;
            avcLabel.Location = new Point(60, 261);
            avcLabel.Name = "avcLabel";
            avcLabel.Size = new Size(286, 15);
            avcLabel.TabIndex = 19;
            avcLabel.Text = "Please Select Your Code Language To Calculate LOC :";
            // 
            // avcCombobox
            // 
            avcCombobox.FormattingEnabled = true;
            avcCombobox.Location = new Point(369, 258);
            avcCombobox.Name = "avcCombobox";
            avcCombobox.Size = new Size(121, 23);
            avcCombobox.TabIndex = 20;
            avcCombobox.SelectedIndexChanged += avcCombobox_SelectedIndexChanged;
            // 
            // Summary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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