using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private bool treeAlive;
        private int numOranges;
        private int orangesEaten;

        public int Age
        {
            set 
            {
                if (value >=0)
                age = value; 
            }
            get { return age; }
        }
        public int Height
        {
            set { height = value; }
            get { return height; }
        }

        public bool TreeAlive
        {
            set { treeAlive = value; }
            get { return treeAlive; }
        }
        public int NumOranges
        {
            get { return numOranges; }
        }
        public int OrangesEaten
        {
            get { return orangesEaten; }
        }

        public void OneYearPasses()
        {
            age++;
            orangesEaten = 0;
            if (age < 80)
            {
                height = height + 2; 
            }
            if (age < 80)
            {
                treeAlive = true; 
            }
            if (age >= 80)
            {
                treeAlive = false;
            }
            if (age >= 2 && age < 80)
            {
                numOranges = 5 * (age - 1);
            }
            else
            {
                numOranges = 0;
            }
          
        }
        public void EatOrange(int count)
        {
            if (count <= numOranges)
            {
                numOranges = numOranges - count;
                orangesEaten = orangesEaten + count;
            }

        }





    }
}
