using Tyuiu.SadykovSV.Sprint5.Task3.V2.Lib;
namespace Tyuiu.SadykovSV.Sprint5.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);
            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists);
        }
    }
}
