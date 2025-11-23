using Tyuiu.BarabashMI.Sprint5.Task0.V15.Lib;
DataService ds = new DataService();
string res = ds.SaveToFileTextData(3);
Console.WriteLine(res);