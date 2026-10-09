using Tyuiu.SadykovSV.Sprint5.Task1.V14.Lib;

Console.Title = "Спринт #5 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #14                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан диапазон [-5; 5]. Произвести табулирование функции и сохранить      *");
Console.WriteLine("* результат в текстовый файл OutPutFileTask1.txt.                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int startValue = -5;
int stopValue = 5;

Console.WriteLine($"startValue = {startValue}");
Console.WriteLine($"stopValue = {stopValue}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(startValue, stopValue);

Console.WriteLine($"Файл успешно сохранен по пути: {res}");
Console.WriteLine();
Console.WriteLine("+----------+----------+");
Console.WriteLine("|    X     |   f(x)   |");
Console.WriteLine("+----------+----------+");

string[] lines = File.ReadAllLines(res);
int currentX = startValue;

foreach (string line in lines)
{
    Console.WriteLine($"| {currentX,8} | {line,8} |");
    currentX++;
}

Console.WriteLine("+----------+----------+");

Console.ReadKey();