using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BarabashMI.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string strX = File.ReadAllText(path);
            foreach (char c in strX)
            { 
                if (char.IsDigit(c))
                    strX = strX.Remove(c);
            }
            return strX;
            
        }

    }
}
