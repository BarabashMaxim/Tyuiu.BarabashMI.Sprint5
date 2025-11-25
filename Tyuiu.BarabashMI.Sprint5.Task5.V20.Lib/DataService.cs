using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BarabashMI.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            NumberFormatInfo info = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };
            string strX = File.ReadAllText(path);
            string[] strings = strX.Split(",");
            List<int> numbers = new List<int>();
            foreach (string str in strings)
            {
                if (int.TryParse(str.Trim(), out int number) & number>=-10 & number <=10)
                    numbers.Add(number);
            }
            double res = 0;
            foreach (int number in numbers)
            { 
                res += number;
            }
            res /= numbers.Count;
            return res;
        }
    }
}
