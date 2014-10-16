using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creepy_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal age1 = numericUpDown1.Value;
            decimal age2 = numericUpDown2.Value;
            decimal ageLargest = 0;
            decimal ageSmallest = 0;
            if (age1 > age2)
            {
                ageLargest = age1;
                ageSmallest = age2;
            }
            else
            {
                ageLargest = age2;
                ageSmallest = age1;
            }
            decimal minAge = ageLargest / 2 + 7;
            string minAgeString = minAge.ToString();

            label3.Text = minAgeString;

            if (ageSmallest < minAge)
            {
                MessageBox.Show("this relationship is creepy! \nBeware!");
            }
                
        }
    }
}
