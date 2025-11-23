using Tyuiu.BarabashMI.Sprint5.Task1.V18.Lib;
namespace Tyuiu.BarabashMI.Sprint5.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            string path = ds.SaveToFileTextData(start, end);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            Assert.IsTrue(fileExist);
        }
    }
}
