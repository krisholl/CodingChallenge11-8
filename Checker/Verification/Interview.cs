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
        public bool IsVerified(int[] Individual, int Total)
        {
            int[] Very = new int[2];
            int[] Easy = new int[2];
            int[] Med = new int[2];
            int[] Hard = new int[2];
            Array.ConstrainedCopy(Individual, 0, Very, 0, 2);
            Array.ConstrainedCopy(Individual, 2, Easy, 0, 2);
            Array.ConstrainedCopy(Individual, 4, Med, 0, 2);
            Array.ConstrainedCopy(Individual, 6, Hard, 0, 2);
            return Array.TrueForAll(Very, p =>p<=5) && Array.TrueForAll(Easy,p => p<=10) && Array.TrueForAll(Med, p=> p<=15) && Array.TrueForAll(Hard,p=> p<=20) && Total<=120;
        }
         
    }
}
