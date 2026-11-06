using Tyuiu.SadykovSV.Sprint5.Task6.V19.Lib;

Console.Title = "Спринт #5 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #19                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask6V19.txt. Найти количество   *");
Console.WriteLine("* двузначных чисел в заданной строке.                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
string path = @"C:\DataSprint5\InPutDataFileTask6V19.txt";

Console.WriteLine($"Данные находятся в файле: {path}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.LoadFromDataFile(path);
Console.WriteLine($"Количество двузначных чисел в файле: {res}");

Console.ReadKey();