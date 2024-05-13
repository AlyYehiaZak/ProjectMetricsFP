using System;
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
    public partial class Summary : Form
    {
        Dictionary<string, int> avcTable = new Dictionary<string, int>() {
            {"Assembly Language",320 },
            {"C",128 },
            {"COBOL/Fortran",105 },
            {"Pascal",90 },
            {"Ada",70 },
            {"C++",64 },
            {"Visual Basic",32 },
            {"Object-Oriented Languages",30 },
            {"Smalltalk",22 },
            {"Code Generators (PowerBuilder)",15 },
            {"SQL/Oracle",12 },
            {"Spreadsheets",6 },
            {"Graphical Langugaes (icons)",4 },
        };
        public Summary(int ufp, int di, double tcf)
        {
            InitializeComponent();

            ufpTextbox.Text = ufp.ToString("0");
            diTextbox.Text = di.ToString("0.00");
            tcfTextbox.Text = tcf.ToString("0.00");
            fpTextbox.Text = ((double)ufp * tcf).ToString("0.00");
            initializeAVCCombobox();
        }

        private void initializeAVCCombobox()
        {
            foreach (string key in avcTable.Keys)
                avcCombobox.Items.Add(key);
        }

        private void avcCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ? indicates that it can return null instead of giving an exception
            string selectedLanguage = avcCombobox.SelectedItem?.ToString();

            // Check if the selected item is not null and exists in the dictionary
            if (!string.IsNullOrEmpty(selectedLanguage) && avcTable.ContainsKey(selectedLanguage))
            {
                // Update the TextBox with the corresponding value
                locTextbox.Text = ((double)avcTable[selectedLanguage] * Convert.ToDouble(fpTextbox.Text)).ToString("0.00");
            }
            else
                locTextbox.Clear();
        }
    }
}
