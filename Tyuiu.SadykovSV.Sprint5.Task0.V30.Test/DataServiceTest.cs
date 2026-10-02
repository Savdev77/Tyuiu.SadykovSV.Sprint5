using Tyuiu.SadykovSV.Sprint5.Task0.V30.Lib;
namespace Tyuiu.SadykovSV.Sprint5.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.IsTrue(fileExist);
        }
    }
}
