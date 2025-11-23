using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BarabashMI.Sprint5.Task1.V18.Lib
{
    public class DataService : ISprint5Task1V18
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            double y;
            string stry;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            { 
                File.Delete(path);
            }

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(3 * x + 2 - (2 * x - x) / (Math.Cos(x) + 1),2);
                stry = Convert.ToString(y);

                if (x != stopValue)
                    File.AppendAllText(path, stry + Environment.NewLine);
                else
                    File.AppendAllText(path, stry);

            }
            return path;
        }
    }
}
