using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DolgovIV.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = false;

            if ((y>=Math.Pow(x,2)) && (y<=Math.Pow(Math.Exp(1), -x)) && (y <= Math.Pow(Math.Exp(1), x)))
            {
                res = true;
            }
            return res;
        }
    }
}
