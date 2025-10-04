
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DolgovIV.Sprint2.Task1.V18.Lib
{
    public class DataService : ISprint2Task1V18
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = a == b | a + d == b;
            res[1] = a != b & b != c;
            res[2] = a < b || a < b;
            res[3] = a > b && a > d;
            res[4] = !(d <= c);
            res[5] = a >= c ^ d >= b;

            return res;
        }
    }
}
