using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BarabashMI.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string pathh = Path.Combine(Path.GetTempPath(), "OutPutDatafileTask7V1.txt");
            FileInfo fileInfo = new FileInfo(pathh);
            bool fileExist = fileInfo.Exists;
            if (fileExist)
                File.Delete(pathh);

            string strX = File.ReadAllText(path);
            string res = "";
            foreach (char c in strX)
            {
                if (!char.IsDigit(c))
                    res += c;
            }
            
            File.WriteAllText(pathh, res);
            return pathh;
            
        }

    }
}
