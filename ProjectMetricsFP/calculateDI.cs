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
    public partial class calculateDI : Form
    {
        ComboBox[] comboBox;
        public static int diValue = 0;
        public calculateDI()
        {
            InitializeComponent();
            comboBox = new ComboBox[14] { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, comboBox8, comboBox9, comboBox10, comboBox11, comboBox12, comboBox13, comboBox14 };
            for (int i = 0; i < comboBox.Length; i++)
            {
                comboBox[i].Items.AddRange(new object[] { "No influence", "incidiental", "Moderate", "Average", "Significant", "Essential" });
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> D = new Dictionary<string, int>()
            {
                {"No influence",0 },
                {"incidiental",1 },
                {"Moderate",2 },
                {"Average",3 },
                {"Significant",4 },
                {"Essential",5 },
            };
            int sum = 0;
            for (int i = 0; i < comboBox.Length; i++)
            {
                sum += D[comboBox[i].Text];
            }
            //MessageBox.Show("the result is: "+sum.ToString());
            diValue = sum;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
