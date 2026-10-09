using Tyuiu.SadykovSV.Sprint5.Task2.V27.Lib;

Console.Title = "Спринт #5 | Выполнил: Садыков С.В. | ПИНб-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #27                                                             *");
Console.WriteLine("* Выполнил: Садыков С.В. | ПИНб-26-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int rows = 3;
int columns = 3;
int[,] matrix = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"Введите элемент массива [{i},{j}]: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(matrix);
Console.WriteLine($"Файл успешно сохранен по пути: {res}");

Console.WriteLine("Данные из сохраненного файла:");
string[] lines = File.ReadAllLines(res);
foreach (string line in lines)
{
    string[] values = line.Split(';');
    foreach(string value in values)
    {
        Console.Write($"{value,3}");
    }
    Console.WriteLine();
}
Console.ReadKey();