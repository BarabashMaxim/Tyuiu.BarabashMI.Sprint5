using System.Diagnostics;
using Tyuiu.BarabashMI.Sprint5.Task0.V15.Lib;
namespace Tyuiu.BarabashMI.Sprint5.Task0.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = $@"E:\.solution\Tyuiu.BarabashMI.Sprint5\Tyuiu.BarabashMI.Sprint5.Task0.V15.Lib\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
