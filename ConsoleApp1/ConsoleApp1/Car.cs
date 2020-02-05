using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {   public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked = false;//Denna bool är automatiskt satt på false men blir true när man kollat igenom en bil.
        public Random generator = new Random();

        public bool Examine()
        {
            alreadyChecked = true;
            return contrabandAmount < 0;//så länge constrabandAmount är lägre än 0 så reurnernar den false, Ifall 
            
        }
    }
}
