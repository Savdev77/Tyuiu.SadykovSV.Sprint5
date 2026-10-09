using Tyuiu.SadykovSV.Sprint5.Task1.V14.Lib;
namespace Tyuiu.SadykovSV.Sprint5.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetSaveToFileTextData()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            string path = ds.SaveToFileTextData(startValue, stopValue);
            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists);
        }
    }
}
