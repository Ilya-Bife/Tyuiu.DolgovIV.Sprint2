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
                    2 => "31" + "." + "0" + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    3 => "29" + "." + "0" + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    4 => "31" + "." + "0" + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    5 => "30" + "." + "0" + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    6 => "31" + "." + "0" + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    7 => "30" + "." + "0" + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    8 => "31" + "." + "0" + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    9 => "31" + "." + "0" + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    10 => "30" + "." + "0" + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    11 => "31" + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                    12 => "30" + "." + Convert.ToString(m - 1) + "." + Convert.ToString(g),
                };
            }
            else
            {
                string mon = (Convert.ToString(m).Length == 2) ? Convert.ToString(m) : ("0" + Convert.ToString(m));
                string num = (Convert.ToString(n - 1).Length == 2) ? Convert.ToString(n - 1) : ("0" + Convert.ToString(n - 1));
                res = num + "." + mon + "." + Convert.ToString(g);
            }
            return res;
            
        }
    }
}
