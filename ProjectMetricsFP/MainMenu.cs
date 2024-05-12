﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMetricsFP
{
    public partial class MainMenu : Form
    {


        public MainMenu()
        {
            InitializeComponent();


        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            calculateUFP ufpCalc;
            calculateDI diCalc;

            //If all givens are not empty
            if (!(string.IsNullOrEmpty(ufpTextbox.Text)) && !(string.IsNullOrEmpty(diTextbox.Text)) && !(string.IsNullOrEmpty(tcfTextbox.Text)))
            {
                MessageBox.Show("All not empty");
            }

            bool istcfgiven = true;
            //If TCF is empty

            if (string.IsNullOrEmpty(tcfTextbox.Text))
            {
                istcfgiven = false;
            }

            //If UFP empty
            if (string.IsNullOrEmpty(ufpTextbox.Text))
            {
                ufpCalc = new calculateUFP();
                DialogResult result = ufpCalc.ShowDialog();
                Visible = false;

                if(result == DialogResult.OK)
                {
                    MessageBox.Show(calculateUFP.ufpValue.ToString());
                }

                if (istcfgiven)
                {
                    string val = tcfTextbox.Text.ToString();
                    float di=(float)((int.Parse(val)-0.65)/0.01);
                    MessageBox.Show("di value is: "+di);
                }
                
            }
            
         
          

            //If BOTH DI and TCF are empty
            if (string.IsNullOrEmpty(diTextbox.Text) && (string.IsNullOrEmpty(tcfTextbox.Text)))
            {
                diCalc = new calculateDI();
                DialogResult result = diCalc.ShowDialog();
                Visible = false;
                MessageBox.Show(calculateDI.divlaue.ToString());
            }
            if (istcfgiven && !string.IsNullOrEmpty(ufpTextbox.Text))
            {
                string val = tcfTextbox.Text.ToString();
                float di = (float)((int.Parse(val) - 0.65) / 0.01);
                MessageBox.Show("di value is: " + di);
            }

            if (!istcfgiven )
            {
                float tcfvalue = (float)(0.65 + 0.01 * calculateDI.divlaue);
                MessageBox.Show("tcf value is: " + tcfvalue);

            }
    
            Close();
            
        }
    }
}
