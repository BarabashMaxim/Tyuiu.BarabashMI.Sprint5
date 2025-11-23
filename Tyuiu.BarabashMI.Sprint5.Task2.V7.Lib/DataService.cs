using System.Data;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BarabashMI.Sprint5.Task2.V7.Lib
{
    public class DataService : ISprint5Task2V7
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            if (fileExist)
                File.Delete(path);

            int[,] matr = { { 9, 2, 8 }, { 7, 1, 2 }, { 5, 5, 1 } };

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] % 2 != 0)
                        matr[i, j] = 0;
                }
            }
            string str = "";
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (j != matr.GetLength(1) - 1)
                        str = str + matr[i, j] + ";";
                    else
                        str = str + matr[i, j];
                }
                if (i != matr.GetLength(0) - 1)
                    File.AppendAllText(path, str + Environment.NewLine);
                else
                    File.AppendAllText(path, str);
                str = "";
            }
            return path;
        }
    }
}
