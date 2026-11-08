using Tyuiu.SadykovSV.Sprint5.Task7.V22.Lib;
Console.Title = "Спринт #5 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #22                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V22.txt. Заменить все знаки *");
Console.WriteLine("* препинания на #. Полученный результат сохранить в новый файл            *");
Console.WriteLine("* OutPutDataFileTask7V22.txt.                                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
string path = @"C:\DataSprint5\InPutDataFileTask7V22.txt";

Console.WriteLine($"Данные находятся в файле: {path}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string resPath = ds.LoadDataAndSave(path);
Console.WriteLine($"Новый файл успешно сохранен по пути:\n{resPath}\n");

Console.ReadKey();