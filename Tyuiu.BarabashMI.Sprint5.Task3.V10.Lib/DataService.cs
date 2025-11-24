using System.Text.Unicode;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BarabashMI.Sprint5.Task3.V10.Lib
{
    public class DataService : ISprint5Task3V10
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(),"OutPutFileTask3.bin");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
                File.Delete(path);
            double res = -Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 1.5 * x;
            res = Math.Round(res,3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), System.Text.Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(res));
            }
            return path;

        }
    }
}
