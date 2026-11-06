using System.Diagnostics.Tracing;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SadykovSV.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] numbers = text.Split(' ');
            int num = 0;
            foreach (string item in numbers)
            {
                if (int.TryParse(item, out num))
                {
                    break;
                }
            }
            double res = 1;
            for (int i = 1; i <= num; i++)
            {
                res *= i;
            }
            return Math.Round(res, 3);
        }
    }
}
