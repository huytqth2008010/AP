using T2008M_AP.Lab.S1;

namespace T2008M_AP.Lab.s2
{
    public class Diamon : Product
    {
        public int cara;

        public bool CheckAuth()
        {
            if (cara > 10)
                return true;
            return false;
        }
    }
}