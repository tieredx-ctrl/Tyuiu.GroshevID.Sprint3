using Tyuiu.GroshevID.Sprint3.Task6.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил: Грошев И. Д. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Вложенные циклы                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Грошев Илья Дмитриевич | РППб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
        Console.WriteLine("* числовому отрезку [19, 31] количество всех делителей                    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = 19;
        int stopValue = 31;

        Console.WriteLine("Начальное число отрезка: " + startValue);
        Console.WriteLine("Конечное число отрезка: " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Количество всех делителей числового отрезка: " + ds.GetSumTheDivisors(startValue, stopValue));

        Console.ReadKey();
    }
}