using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArray
{
    //1 2 3 4 => 4 1 2 3
    internal class RotateArray
    {
        public List<T> RotateRightOneTime<T>(List<T> list)
        {
            var total = list.Count - 1;
            var last = list[total];

            for (int i = total; i > 0; i--)
            {
                list[i] = list[i - 1];
            }
            list[0] = last;
            return list;
        }

        public List<T> RotateRight<T>(int totalRotations, List<T> list)
        {
            var total = list.Count();
            for (int i = 0; i < totalRotations % total; i++)
            {
                RotateRightOneTime<T>(list);
            }
            return list;
        }

        public List<T> RotateLeft<T>(int totalRotations, List<T> list)
        {
            var total = list.Count();
            for (int i = 0; i < totalRotations % total; i++)
            {
                RotateLeftOneTime<T>(list);
            }
            return list;
        }

        // 1 2 3 4 => 2 3 4 1
        public List<T> RotateLeftOneTime<T>(List<T> list)
        {
            var total = list.Count - 1;
            var first = list[0];

            for (int i = 0; i < total; i++)
            {
                list[i] = list[i + 1];
            }
            list[total] = first;
            return list;
        }
    }
}
