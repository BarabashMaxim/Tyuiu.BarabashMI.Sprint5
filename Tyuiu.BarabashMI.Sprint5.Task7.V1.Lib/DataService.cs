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
            foreach (char c in strX)
            { 
                if (char.IsDigit(c))
                    strX = strX.Remove(c);
            }
            
            File.WriteAllText(pathh, strX);
            return pathh;
            
        }

    }
}
