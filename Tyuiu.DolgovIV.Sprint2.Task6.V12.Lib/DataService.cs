using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DolgovIV.Sprint2.Task6.V12.Lib 
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string res; 
            if (n == 1)
            {
                res = m switch
                {
                    1 => "31" + "." + "12" + "." + Convert.ToString(g - 1),
                    2 => "31" + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    3 => "29" + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    4 => "31" + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    5 => "30" + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    6 => "31" + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    7 => "30" + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    8 => "31" + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    9 => "31" + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    10 => "30" + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    11 => "31" + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    12 => "30" + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                };
            }
            else
            { 
                res = Convert.ToString(n-1) + "." + Convert.ToString(m) + "." + Convert.ToString(g);
            }
            return res;
            
        }
    }
}
