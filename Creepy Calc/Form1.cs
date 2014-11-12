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
            Calc AgeCalc = new Calc(); //Defines the new Creepy calculator

            //The next two variables define where to get the values for the ages of the persons in the relationship
            AgeCalc.Age1 = numericUpDown3.Value; 
            AgeCalc.Age2 = numericUpDown2.Value;


            label3.Text = AgeCalc.MinAge.ToString(); //allows the GUI to display the value of AgeCalc.MinAge by changing the decimal to a string
            
            //these two if statements control the display of a message box alerting the user to weather their relationship is creepy or not
            if (AgeCalc.Iscreepy == true)
            {
                MessageBox.Show("this relationship is creepy! \nBeware!");
            }
            if (AgeCalc.Iscreepy == false)
            {
                MessageBox.Show("this relationship is not creepy! \nDon't have too much fun you crazy kids!");
            }
            
                
        }
    }
}
