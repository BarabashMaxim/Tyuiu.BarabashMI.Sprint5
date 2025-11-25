using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BarabashMI.Sprint5.Task4.V8.Lib
{
    public class DataService : ISprint5Task4V8
    {
        public double LoadFromDataFile(string path)
        {
            NumberFormatInfo info = new NumberFormatInfo
            {
                NumberDecimalSeparator = "."
            };
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX, info);
            double res = Math.Pow(x, 2) / Math.Sin(x) + 3;
            return Math.Pow(res,3);
        }
    }
}
