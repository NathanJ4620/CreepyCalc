using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creepy_Calc
{
    class Calc
    {
        private decimal age1;
        private decimal age2;
        private decimal oldest;
        private decimal youngest;
        private decimal minage;
        private bool isCreepy;
        private decimal ageGap;

        public decimal Age1
        {
            get { return this.age1; }
            set { this.age1 = value; }
        }

        public decimal Age2
        {
            get { return this.age2; }
            set { this.age2 = value; }
        }
        public decimal Oldest
        {
            get {   if (age1 > age2)
            {
                oldest = age1;
                    return age1;
                    
            }
                
                else
            {
                oldest = age2;
                return age2;
            }
                
            }
            

        }
        public decimal Youngest
        {
            get
            {
                if (age1 > age2)
                {
                    youngest = age2;
                    return age2;
                }

                else
                {
                    youngest = age2;
                    return age1;
                }



            }
        }
        public decimal MinAge
        {
            get
            {
                return oldest / 2 + 7;
            }
            set
            {
                minage = value;
            }
        }
        public bool Iscreepy
        {
            get
            {
                if (youngest >= minage)
                {
                    isCreepy = false;
                    return isCreepy;
                }
                else
                {
                    isCreepy = true;
                    return isCreepy;
                }
            }
        }
        public decimal AgeGap
        {
            get
            {
                ageGap = oldest - youngest;
                return ageGap;
            }
        }
	
    }
}
