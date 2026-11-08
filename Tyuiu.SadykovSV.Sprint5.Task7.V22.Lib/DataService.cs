using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SadykovSV.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string savePath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V22.txt");

            FileInfo fileInfo = new FileInfo(savePath);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }

            string content = File.ReadAllText(path);
            string punct = ",.!?:;-";
            foreach(char c in punct)
            {
                content = content.Replace(c, '#');
            }
            File.WriteAllText(savePath, content);
            return savePath;
        }
    }
}
