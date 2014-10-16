using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creepy_Calc
{
    class Creepy
    {
        private decimal age1;
        private decimal age2;
        private decimal ageLargest;
        private decimal ageSmallest;
        private decimal minAge;
        private decimal ageGap;
        private bool isItCreepy;

        public bool IsItCreepy
        {
            get { return this.isItCreepy; }
        }
        public decimal Age1
        {
            get { return this.age1; }
            set
            {
                if (value < 0)
                {
                    System.Windows.Forms.MessageBox.Show("age cannot be less than zero");
                }
                else
                {
                   this.age1 = value;
                }

                
            }
        }
        public decimal Age2
        {
            get { return this.age2; }
            set
            {
                if (value < 0)
                {
                    System.Windows.Forms.MessageBox.Show("age cannot be less than zero");
                }
                else
                {
                   this.age2 = value;
                }

                
            }
        }
        public decimal AgeLargest
        {
            get { return this.ageLargest; }
            set
            {
                if (age1 > age2)
                {
                    this.ageLargest = age1;
                    this.ageSmallest = age2;
                }
                if (age1 == age2)
                {
                    System.Windows.Forms.MessageBox.Show("you are the same age, congrats! it's not creepy");
                    isItCreepy = false;
                }
                else
                {
                    this.ageLargest = age2;
                    this.ageSmallest = age1;
                }
            }
        }
        public decimal MinAge
        {
            get { return this.minAge; }
            set
            {
                this.minAge = ageLargest / 2 + 7;
            }
        }
        public decimal AgeGap
        {
            get { return this.ageGap; }
            set
            {
                this.ageGap = ageLargest - ageSmallest;
            }
        }
        
    }
}
