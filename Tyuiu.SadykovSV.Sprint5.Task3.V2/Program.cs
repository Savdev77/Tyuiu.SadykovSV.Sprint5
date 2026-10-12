using Tyuiu.SadykovSV.Sprint5.Task3.V2.Lib;

Console.Title = "Спринт #5 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дано выражение y = e^x / x. Вычислить его значение при x = 3, результат *");
Console.WriteLine("* сохранить в бинарный файл OutPutFileTask3.bin и вывести на консоль.     *");
Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int x = 3;

Console.WriteLine($"Значение x = {x}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(x);
Console.WriteLine($"Файл успешно сохранен по пути: {res}\n");
double resultFromBinary;
using (BinaryReader reader = new BinaryReader(File.Open(res, FileMode.Open)))
{
    resultFromBinary = reader.ReadDouble();
}

Console.WriteLine($"Результат вычислений: {resultFromBinary}");

Console.ReadKey();