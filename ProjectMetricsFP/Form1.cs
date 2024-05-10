using System.Drawing.Text;

namespace ProjectMetricsFP
{
    public partial class Form1 : Form
    {
        TextBox[][] textBoxesComplexities;
        TextBox[] totalTextBoxes;
        public Form1()
        {
            //This a test to commit project
            InitializeComponent();

            textBoxesComplexities = new TextBox[3][] {
                 new TextBox[] { inputSimple, outputSimple, inquirySimple, interfaceSimple, logicalSimple },
                 new TextBox[] { inputAverage, outputAverage, inquiryAverage, interfaceAverage, logicalAverage },
                 new TextBox[] { inputComplex, outputComplex, inquiryComplex, interfaceComplex, logicalComplex }
            };

            totalTextBoxes = new TextBox[] { inputTotal, outputTotal, inquiryTotal, interfaceTotal, logicalTotal };

            //Initializing Placeholders
            foreach (var textbox in textBoxesComplexities[0])
            {
                textbox.Text = "Simple";
                textbox.ForeColor = SystemColors.GrayText;

                textbox.Enter += (s, evt) => TextBox_Enter(s, evt, "Simple");
                textbox.Leave += (s, evt) => TextBox_Leave(s, evt, "Simple");
            }
            foreach (var textbox in textBoxesComplexities[1])
            {
                textbox.Text = "Average";
                textbox.ForeColor = SystemColors.GrayText;

                textbox.Enter += (s, evt) => TextBox_Enter(s, evt, "Average");
                textbox.Leave += (s, evt) => TextBox_Leave(s, evt, "Average");
            }
            foreach (var textbox in textBoxesComplexities[2])
            {
                textbox.Text = "Complex";
                textbox.ForeColor = SystemColors.GrayText;

                textbox.Enter += (s, evt) => TextBox_Enter(s, evt, "Complex");
                textbox.Leave += (s, evt) => TextBox_Leave(s, evt, "Complex");
            }

            //this.BackColor = ColorTranslator.FromHtml("#164073");
            //Color labelColor = ColorTranslator.FromHtml("#FFFFFF");

            /*foreach (Control control in this.Controls)
            {
                // Check if the control is a label
                if (control is Label)
                {
                    // Set the ForeColor of the label to the desired color
                    ((Label)control).ForeColor = labelColor;
                }
            }
            */

        }

        private void TextBox_Enter(object sender, EventArgs e, string complexity)
        {
            var textBox = (TextBox)sender;
            // Clean when focused
            if (textBox.Text == complexity)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e, string complexity)
        {
            var textBox = (TextBox)sender;
            // Replace placeholder when unfocused

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = complexity;
                textBox.ForeColor = SystemColors.GrayText;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateUFP_Click(object sender, EventArgs e)
        {
            verifyInputs();
        }

        private void verifyInputs()
        {
            string[] complexities = new string[3] { "Simple", "Average", "Complex" };

            for (int i = 0; i < 5; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    //Check if Simple,Average,Complex textbox empty
                    if (complexities[i].Equals(textBoxesComplexities[j][i].Text))
                    {
                        MessageBox.Show("Error: Empty textbox at " + textBoxesComplexities[j][i].Name, "Error Mismatch");
                        break;
                    }

                    sum += Convert.ToInt32(textBoxesComplexities[j][i].Text);
                }

                //Check if Total textbox empty
                if (!string.IsNullOrEmpty(totalTextBoxes[i].Text))
                {
                    //Check if total num of inputs equal sum of simple,average,complex
                    if (sum != Convert.ToInt32(totalTextBoxes[i].Text))
                    {
                        MessageBox.Show("Error: Mismatch of inputs occured at " + totalTextBoxes[i].Name, "Error Mismatch");
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Error: Empty textbox at " + totalTextBoxes[i].Name);
                    break;
                }

            }
        }
    }
}