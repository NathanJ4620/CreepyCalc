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
            Calc AgeCalc = new Calc();
            AgeCalc.Age1 = numericUpDown3.Value;
            AgeCalc.Age2 = numericUpDown2.Value;
            //decimal ageLargest = 1;
            //decimal ageSmallest = 1;
            //if (AgeCalc.Age1 > AgeCalc.Age2) 
            //{
            //    ageLargest = AgeCalc.Age1;
            //    ageSmallest = AgeCalc.Age2;
            //}
            //if (AgeCalc.Age2 > AgeCalc.Age1)
            //{
            //    ageLargest = AgeCalc.Age2;
            //    ageSmallest = AgeCalc.Age1;
            //}
            decimal minAge = AgeCalc.Oldest / 2 + 7;
            string minAgeString = minAge.ToString();

            label3.Text = minAgeString;
            //Console.WriteLine(" " + ageLargest);
            //Console.WriteLine(" " + ageSmallest);
            //Console.WriteLine(" " + AgeCalc.Age1);
            //Console.WriteLine(" " + AgeCalc.Age2);

            if (AgeCalc.Youngest < minAge)
            {
                MessageBox.Show("this relationship is creepy! \nBeware!");
            }
            if (AgeCalc.Youngest >= minAge)
            {
                MessageBox.Show("this relationship is not creepy! \nDon't have too much fun you crazy kids!");
            }
            MessageBox.Show(AgeCalc.Oldest.ToString() + "/n" + AgeCalc.Age1.ToString());
                
        }
    }
}
