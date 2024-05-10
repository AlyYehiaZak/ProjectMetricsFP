namespace ProjectMetricsFP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputTotal = new TextBox();
            outputTotal = new TextBox();
            interfaceTotal = new TextBox();
            inquiryTotal = new TextBox();
            logicalTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            inputSimple = new TextBox();
            inputAverage = new TextBox();
            inputComplex = new TextBox();
            outputComplex = new TextBox();
            outputAverage = new TextBox();
            outputSimple = new TextBox();
            inquiryComplex = new TextBox();
            inquiryAverage = new TextBox();
            inquirySimple = new TextBox();
            interfaceComplex = new TextBox();
            interfaceAverage = new TextBox();
            interfaceSimple = new TextBox();
            logicalComplex = new TextBox();
            logicalAverage = new TextBox();
            logicalSimple = new TextBox();
            calculateUFP = new Button();
            SuspendLayout();
            // 
            // inputTotal
            // 
            inputTotal.Location = new Point(112, 87);
            inputTotal.Name = "inputTotal";
            inputTotal.Size = new Size(100, 23);
            inputTotal.TabIndex = 0;
            // 
            // outputTotal
            // 
            outputTotal.Location = new Point(112, 196);
            outputTotal.Name = "outputTotal";
            outputTotal.Size = new Size(100, 23);
            outputTotal.TabIndex = 1;
            // 
            // interfaceTotal
            // 
            interfaceTotal.Location = new Point(522, 87);
            interfaceTotal.Name = "interfaceTotal";
            interfaceTotal.Size = new Size(100, 23);
            interfaceTotal.TabIndex = 3;
            // 
            // inquiryTotal
            // 
            inquiryTotal.Location = new Point(112, 317);
            inquiryTotal.Name = "inquiryTotal";
            inquiryTotal.Size = new Size(100, 23);
            inquiryTotal.TabIndex = 2;
            // 
            // logicalTotal
            // 
            logicalTotal.Location = new Point(522, 203);
            logicalTotal.Name = "logicalTotal";
            logicalTotal.Size = new Size(100, 23);
            logicalTotal.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 90);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 6;
            label1.Text = "External Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 199);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 7;
            label2.Text = "External Output";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 320);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 8;
            label3.Text = "External Inquiry";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 90);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 9;
            label4.Text = "External Interface Files";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 206);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 10;
            label5.Text = "Internal Logical Files";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 9);
            label7.Name = "label7";
            label7.Size = new Size(296, 28);
            label7.TabIndex = 12;
            label7.Text = "Enter Your Data To Calculate UFP";
            // 
            // inputSimple
            // 
            inputSimple.Location = new Point(235, 58);
            inputSimple.Name = "inputSimple";
            inputSimple.Size = new Size(100, 23);
            inputSimple.TabIndex = 13;
            inputSimple.Tag = "Simple";
            // 
            // inputAverage
            // 
            inputAverage.Location = new Point(235, 87);
            inputAverage.Name = "inputAverage";
            inputAverage.Size = new Size(100, 23);
            inputAverage.TabIndex = 14;
            inputAverage.Tag = "Average";
            // 
            // inputComplex
            // 
            inputComplex.Location = new Point(235, 116);
            inputComplex.Name = "inputComplex";
            inputComplex.Size = new Size(100, 23);
            inputComplex.TabIndex = 15;
            inputComplex.Tag = "Complex";
            // 
            // outputComplex
            // 
            outputComplex.Location = new Point(235, 232);
            outputComplex.Name = "outputComplex";
            outputComplex.Size = new Size(100, 23);
            outputComplex.TabIndex = 18;
            outputComplex.Tag = "Complex";
            // 
            // outputAverage
            // 
            outputAverage.Location = new Point(235, 203);
            outputAverage.Name = "outputAverage";
            outputAverage.Size = new Size(100, 23);
            outputAverage.TabIndex = 17;
            outputAverage.Tag = "Average";
            // 
            // outputSimple
            // 
            outputSimple.Location = new Point(235, 174);
            outputSimple.Name = "outputSimple";
            outputSimple.Size = new Size(100, 23);
            outputSimple.TabIndex = 16;
            outputSimple.Tag = "Simple";
            // 
            // inquiryComplex
            // 
            inquiryComplex.Location = new Point(235, 346);
            inquiryComplex.Name = "inquiryComplex";
            inquiryComplex.Size = new Size(100, 23);
            inquiryComplex.TabIndex = 21;
            inquiryComplex.Tag = "Complex";
            // 
            // inquiryAverage
            // 
            inquiryAverage.Location = new Point(235, 317);
            inquiryAverage.Name = "inquiryAverage";
            inquiryAverage.Size = new Size(100, 23);
            inquiryAverage.TabIndex = 20;
            inquiryAverage.Tag = "Average";
            // 
            // inquirySimple
            // 
            inquirySimple.Location = new Point(235, 288);
            inquirySimple.Name = "inquirySimple";
            inquirySimple.Size = new Size(100, 23);
            inquirySimple.TabIndex = 19;
            inquirySimple.Tag = "Simple";
            // 
            // interfaceComplex
            // 
            interfaceComplex.Location = new Point(648, 116);
            interfaceComplex.Name = "interfaceComplex";
            interfaceComplex.Size = new Size(100, 23);
            interfaceComplex.TabIndex = 24;
            interfaceComplex.Tag = "Complex";
            // 
            // interfaceAverage
            // 
            interfaceAverage.Location = new Point(648, 87);
            interfaceAverage.Name = "interfaceAverage";
            interfaceAverage.Size = new Size(100, 23);
            interfaceAverage.TabIndex = 23;
            interfaceAverage.Tag = "Average";
            // 
            // interfaceSimple
            // 
            interfaceSimple.Location = new Point(648, 58);
            interfaceSimple.Name = "interfaceSimple";
            interfaceSimple.Size = new Size(100, 23);
            interfaceSimple.TabIndex = 22;
            interfaceSimple.Tag = "Simple";
            // 
            // logicalComplex
            // 
            logicalComplex.Location = new Point(648, 232);
            logicalComplex.Name = "logicalComplex";
            logicalComplex.Size = new Size(100, 23);
            logicalComplex.TabIndex = 27;
            logicalComplex.Tag = "Complex";
            // 
            // logicalAverage
            // 
            logicalAverage.Location = new Point(648, 203);
            logicalAverage.Name = "logicalAverage";
            logicalAverage.Size = new Size(100, 23);
            logicalAverage.TabIndex = 26;
            logicalAverage.Tag = "Average";
            // 
            // logicalSimple
            // 
            logicalSimple.Location = new Point(648, 174);
            logicalSimple.Name = "logicalSimple";
            logicalSimple.Size = new Size(100, 23);
            logicalSimple.TabIndex = 25;
            logicalSimple.Tag = "Simple";
            // 
            // calculateUFP
            // 
            calculateUFP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            calculateUFP.Location = new Point(642, 332);
            calculateUFP.Name = "calculateUFP";
            calculateUFP.Size = new Size(106, 49);
            calculateUFP.TabIndex = 28;
            calculateUFP.Text = "Calculate UFP";
            calculateUFP.UseVisualStyleBackColor = true;
            calculateUFP.Click += calculateUFP_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(calculateUFP);
            Controls.Add(logicalComplex);
            Controls.Add(logicalAverage);
            Controls.Add(logicalSimple);
            Controls.Add(interfaceComplex);
            Controls.Add(interfaceAverage);
            Controls.Add(interfaceSimple);
            Controls.Add(inquiryComplex);
            Controls.Add(inquiryAverage);
            Controls.Add(inquirySimple);
            Controls.Add(outputComplex);
            Controls.Add(outputAverage);
            Controls.Add(outputSimple);
            Controls.Add(inputComplex);
            Controls.Add(inputAverage);
            Controls.Add(inputSimple);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logicalTotal);
            Controls.Add(interfaceTotal);
            Controls.Add(inquiryTotal);
            Controls.Add(outputTotal);
            Controls.Add(inputTotal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTotal;
        private TextBox outputTotal;
        private TextBox interfaceTotal;
        private TextBox inquiryTotal;
        private TextBox logicalTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox inputSimple;
        private TextBox inputAverage;
        private TextBox inputComplex;
        private TextBox outputComplex;
        private TextBox outputAverage;
        private TextBox outputSimple;
        private TextBox inquiryComplex;
        private TextBox inquiryAverage;
        private TextBox inquirySimple;
        private TextBox interfaceComplex;
        private TextBox interfaceAverage;
        private TextBox interfaceSimple;
        private TextBox logicalComplex;
        private TextBox logicalAverage;
        private TextBox logicalSimple;
        private Button calculateUFP;
    }
}