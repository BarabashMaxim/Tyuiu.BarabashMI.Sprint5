using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BarabashMI.Sprint5.Task6.V30.Lib
{
    public class Class1 : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            string[] words = strX.Split(" ");
            int count = 0;
            foreach (string str in words)
            { 
                if (str.Length == 8)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
