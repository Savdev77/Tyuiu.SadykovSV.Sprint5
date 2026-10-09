using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SadykovSV.Sprint5.Task1.V14.Lib
{
    public class DataService : ISprint5Task1V14
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            string strY;
            double y;
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1.7 == 0)
                {
                    y = 0;
                }
                y = Math.Round((Math.Sin(x) / (x + 1.7)) - (Math.Cos(x) * 4 * x) - 6, 2);
                strY = Convert.ToString(y);
                File.AppendAllText(path, strY + Environment.NewLine);
            }
            return path;
        }
    }
}
