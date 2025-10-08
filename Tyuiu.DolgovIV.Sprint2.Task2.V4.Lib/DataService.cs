using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DolgovIV.Sprint2.Task2.V4.Lib
{
    public class DataService : ISprint2Task2V4
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            int[] Array1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] Array2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] Array3 = { 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0 };
            int[] Array4 = { 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0 };
            int[] Array5 = { 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 0, 0, 0 };
            int[] Array6 = { 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0 };
            int[] Array7 = { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0 };
            int[] Array8 = { 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0 };
            int[] Array9 = { 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0 };
            int[] Array10 = { 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0 };
            int[] Array11 = { 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0 };
            int[] Array12 = { 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0 };
            int[] Array13 = { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] Array14 = { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] Array15 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            int[][] bracket = { Array1, Array2, Array3, Array4, Array5, Array6, Array7, Array8, Array9, Array10, Array11, Array12, Array13, Array14, Array15 };

            if (x>15 || x<1 || y>15 || y<1) return true;

            if (bracket[x - 1][y - 1] == 0) return true;
            else return false;





        }
    }
}
