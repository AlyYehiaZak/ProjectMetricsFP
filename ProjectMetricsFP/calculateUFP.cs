using System.Drawing.Text;

namespace ProjectMetricsFP
{
    public partial class calculateUFP : Form
    {
        TextBox[][] textBoxesComplexities;
        TextBox[] totalTextBoxes;
        public static int ufpValue = 0;
        Dictionary<int, int[]> complexityTableValues = new Dictionary<int, int[]>();
        public calculateUFP()
        {

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

            //Initialize Complexity Table
            createComplexityTable();




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
            if (verifyInputs())
            {
                calculateUFPValue();

            }
                
        }

        private bool verifyInputs()
        {
            bool valuesVerified = true;
            string[] complexities = new string[3] { "Simple", "Average", "Complex" };

            for (int i = 0; i < 5; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    //Check if Simple,Average,Complex textbox empty
                    if (complexities[j].Equals(textBoxesComplexities[j][i].Text))
                    {
                        MessageBox.Show("Error: Empty textbox at " + textBoxesComplexities[j][i].Name, "Error Mismatch");
                        valuesVerified = false;
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
                        valuesVerified = false;
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Error: Empty textbox at " + totalTextBoxes[i].Name);
                    valuesVerified = false;
                    break;
                }

            }
            return valuesVerified;
        }

        private void createComplexityTable()
        {

            complexityTableValues.Add(0, new int[] { 3, 4, 6 }); //input
            complexityTableValues.Add(1, new int[] { 4, 5, 7 }); // output
            complexityTableValues.Add(2, new int[] { 3, 4, 6 }); //inquiry
            complexityTableValues.Add(3, new int[] { 5, 7, 10 }); //interface
            complexityTableValues.Add(4, new int[] { 7, 10, 15 }); //logical
        }

        private void calculateUFPValue()
        {
            for (int i = 0; i < 5; i++)
            {
                int sumPerParameter = 0;
                for (int j = 0; j < 3; j++)
                {

                    sumPerParameter += Convert.ToInt32(textBoxesComplexities[j][i].Text) * complexityTableValues[i][j];

                }
                ufpValue += sumPerParameter;
            }

            //MessageBox.Show(ufpValue.ToString());
            ufpValue = 0;
        }
    }
}