using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SadykovSV.Sprint5.Task6.V19.Lib
{
    public class DataService : ISprint5Task6V19
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] numbers = text.Split(' ');
            int count = 0;
            foreach (string number in numbers)
            {
                if (int.TryParse(number, out int result))
                {
                    int abs_num = Math.Abs(result);
                    if (abs_num >= 10 && abs_num <= 99)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
