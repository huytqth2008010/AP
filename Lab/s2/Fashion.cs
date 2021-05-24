using System;
using T2008M_AP.Lab.S1;

namespace T2008M_AP.Lab.s2
{
    public class Fashion : Product
    {
        public string color;
        public string size;

        public bool CheckColorAndSize(string c, string s)
        {
            if (color.Equals(c) && size.Equals(s) && qty > 0)
                return true;
            return false;
        }
    }
}