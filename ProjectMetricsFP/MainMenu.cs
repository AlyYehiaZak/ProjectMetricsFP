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

                
            }

            //If BOTH DI and TCF are empty
            if (string.IsNullOrEmpty(diTextbox.Text) && (string.IsNullOrEmpty(tcfTextbox.Text)))
            {
                diCalc = new calculateDI();
                Visible = false;
                MessageBox.Show(calculateUFP.ufpValue.ToString());
            }

            //If TCF is empty
            if (string.IsNullOrEmpty(tcfTextbox.Text))
            {
                MessageBox.Show("tcf empty");
            }

            Close();
            
        }
    }
}