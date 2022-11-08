using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checker.Verification
{
    public class Interview
    {
        public Interview()
        {

        }
        private static int[] levels = {5,5,10,10,15,15,20,20 };
        public bool IsVerified(int[] Individual, int Total)
        {
            if(Total > 120)
            {
                return false;
            }
            int[] Very = new int[2];
            int[] Easy = new int[2];
            int[] Med = new int[2];
            int[] Hard = new int[2];
            Array.ConstrainedCopy(Individual, 0, Very, 0, 2);
            Array.ConstrainedCopy(Individual, 2, Easy, 0, 2);
            Array.ConstrainedCopy(Individual, 4, Med, 0, 2);
            Array.ConstrainedCopy(Individual, 6, Hard, 0, 2);
            return Array.TrueForAll(Very, VeryEasy) && Array.TrueForAll(Easy,EasyMod) && Array.TrueForAll(Med, Medium) && Array.TrueForAll(Hard,HardMod);
        }
        private bool VeryEasy(int time)
        {
            return time <= 5;
        }
        private bool EasyMod(int time)
        {
            return time <= 10;
        }
        private bool Medium(int time)
        {
            return time <= 15;
        }
        private bool HardMod(int time)
        {
            return time <= 20;
        }
    }
}
