using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DolgovIV.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            int z = k / 7;
            string res = "";

            switch ((k%7+(d-1))%7)
            {
                case 1:
                    res = "понедельник";
                    break;
                case 2:
                    res = "вторник";
                    break;
                case 3:
                    res = "среда";
                    break;
                case 4:
                    res = "четверг";
                    break;
                case 5:
                    res = "пятница";
                    break;
                case 6:
                    res = "суббота";
                    break;
                case 7:
                    res = "воскресенье";
                    break;
            }
            return res;
        }
    }
}
