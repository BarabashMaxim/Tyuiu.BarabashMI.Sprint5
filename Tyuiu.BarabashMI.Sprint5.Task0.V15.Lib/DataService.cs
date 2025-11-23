using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BarabashMI.Sprint5.Task0.V15.Lib
{
    public class DataService : ISprint5Task0V15
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = Math.Round(x / (Math.Pow(x, 3) + 2), 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
