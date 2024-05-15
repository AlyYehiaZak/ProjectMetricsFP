using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ProjectMetricsFP
{
    public partial class MainMenu : Form
    {

        public static double tcfValue = 0;
        public MainMenu()
        {
            InitializeComponent();
            DarkModeTheme(this); //Comment it to disable it
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            calculateUFP ufpCalc = new calculateUFP();
            calculateDI diCalc = new calculateDI();
            bool istcfgiven = true;


            //If all givens are not empty
            if (!(string.IsNullOrEmpty(ufpTextbox.Text)) && !(string.IsNullOrEmpty(diTextbox.Text)) && !(string.IsNullOrEmpty(tcfTextbox.Text)))
            {
                calculateUFP.ufpValue = Convert.ToInt32(ufpTextbox.Text);
                calculateDI.diValue = Convert.ToInt32(diTextbox.Text);
                tcfValue = Convert.ToDouble(tcfTextbox.Text);
            }
            else
            {
                //If UFP empty
                if (string.IsNullOrEmpty(ufpTextbox.Text))
                {

                    DialogResult result = ufpCalc.ShowDialog();
                    Visible = false;

                    //if (result == DialogResult.OK)
                    //{
                    //    MessageBox.Show(calculateUFP.ufpValue.ToString());
                    //}
                }
                else
                    calculateUFP.ufpValue = Convert.ToInt32(ufpTextbox.Text);

                //If BOTH DI and TCF are empty
                if (string.IsNullOrEmpty(diTextbox.Text) && (string.IsNullOrEmpty(tcfTextbox.Text)))
                {

                    DialogResult result = diCalc.ShowDialog();
                    Visible = false;
                    //MessageBox.Show(calculateDI.diValue.ToString());
                    if (!istcfgiven)
                    {
                        tcfValue = (double)(0.65 + (0.01 * calculateDI.diValue));
                        //MessageBox.Show("tcf value is: " + tcfValue);
                    }
                }

                //If TCF is empty
                if (string.IsNullOrEmpty(tcfTextbox.Text))
                {
                    istcfgiven = false;
                    if (string.IsNullOrEmpty(diTextbox.Text))
                    {
                        diTextbox.Text = "0";
                    }
                    else
                        calculateDI.diValue = Convert.ToInt32(diTextbox.Text);
                    tcfValue = (double)(0.65 + (0.01 * calculateDI.diValue));
                }
                else
                    tcfValue = Convert.ToDouble(tcfTextbox.Text);


                //if (!istcfgiven)
                //{ 
                //    MessageBox.Show("tcf value is: " + tcfValue);
                //}
            }


            Summary summary = new Summary(calculateUFP.ufpValue, calculateDI.diValue, tcfValue);
            summary.ShowDialog();
            Visible = false;

            Close();

        }
        public static void DarkModeTheme(Control control)
        {
            //Setting background color of the form
            control.BackColor = System.Drawing.ColorTranslator.FromHtml("#0A0E14");

            foreach (Control ctrl in control.Controls)
            {
                //Checking what is the element passed to change its colors
                switch (ctrl)
                {
                    case Label label:
                        label.ForeColor = Color.White;
                        break;
                    case System.Windows.Forms.TextBox textbox:
                        textbox.BackColor = Color.FromArgb(30, 30, 30); // Dark gray
                        textbox.ForeColor = Color.White;
                        break;
                    case System.Windows.Forms.Button button:
                        button.BackColor = Color.FromArgb(0, 31, 61); // Navy blue
                        button.ForeColor = Color.White; 
                        button.Padding = new Padding(5, 10, 5, 10);
                        button.AutoSize = true;
                        break;
                    case System.Windows.Forms.ComboBox combobox:
                        combobox.BackColor = Color.FromArgb(30, 30, 30); // Dark gray
                        combobox.ForeColor = Color.White;
                        break;
                    default:
                        break;
                }

            }
        }

    }
}
