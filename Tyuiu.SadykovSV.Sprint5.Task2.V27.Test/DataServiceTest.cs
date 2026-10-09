using Tyuiu.SadykovSV.Sprint5.Task2.V27.Lib;
namespace Tyuiu.SadykovSV.Sprint5.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3] { { 1, 4, 3 },
                                            { 1, 1, 4 },
                                            { 4, 3, 8 } };
            string path = ds.SaveToFileTextData(matrix);
            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists);
        }
    }
}
