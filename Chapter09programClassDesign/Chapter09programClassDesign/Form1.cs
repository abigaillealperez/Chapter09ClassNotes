using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter09programClassDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblEasterResult_Click(object sender, EventArgs e)
        {

        }

        private void lblLeapYearResult_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            bool flag;
            int year;
            int leap;
            clsDates myDate = new clsDates();

            //Convert validate integer
            flag = int.TryParse(txtYear.Text, out year);
            if (flag == false)
                {
                MessageBox.Show("Digit characters only in YYYY format.", "Input Error");
                txtYear.Focus();
                return;
            }
            leap = myDate.getLeapYear(year);
            lblLeapYearResult.Text = year.ToString() + " is " + ((leap == 1) ? "" : "not ") + "a leap year";
            lblEasterResult.Text = myDate.getEaster(year);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
