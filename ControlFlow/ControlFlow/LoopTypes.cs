using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class LoopTypes
    {
        internal static int HighestForLoop(List<int> nums)
        {
            int highest = -int.MaxValue;
            for (int i = 0; i < nums.Count; i++) {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
            }
            return highest;
        }

        internal static int HighestWhileLoop(List<int> nums)
        {
            int highest = int.MinValue;
            int length = nums.Count;
            int i = 0;
            while(i < length)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;
            }
            return highest;
        }

        internal static int HighestDoWhileLoop(List<int> nums)
        {
            int highest = int.MinValue;
            int length = nums.Count;
            int i = 0;
            do
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;
            } while (i < length - 1);
                return highest;
        }
    }
}
