using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    public class Method
    {
        public static int GetStones(int totalPounds)
        {
            if (totalPounds < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot be less than 0.");
            }
            return totalPounds / 14;
        }

        public static int GetPounds(int totalPounds)
        {
            if (totalPounds < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot be less than 0.");
            }
            return totalPounds % 14;
        }

        public static string GetMarkClassicfication(int mark)
        {
            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }
    }
}
