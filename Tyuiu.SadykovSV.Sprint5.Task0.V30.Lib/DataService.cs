using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SadykovSV.Sprint5.Task0.V30.Lib
{
    public class DataService : ISprint5Task0V30
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            double y = (Math.Pow(x, 2) + 1) / (3.0 * x + 4);
            y = Math.Round(y, 3);

            File.WriteAllText(path, Convert.ToString(y));

            return path;
        }
    }
}
