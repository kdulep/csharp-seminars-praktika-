﻿using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double InputNumber(in string prompt)
{
    bool result;
    do
    {
        Console.WriteLine(prompt);
        string? input = Console.ReadLine();

        result = double.TryParse(input, out var number);
        if (result == true)
        {
            //Console.WriteLine($"Преобразование прошло успешно. Число: {number}");
            return number;
        }
        else
            Console.WriteLine("Преобразование завершилось неудачно. Повторите ввод");
    } while (result);
    return 0;
}

double b1 = InputNumber("Введите b1:");
double k1 = InputNumber("Введите k1:");
double b2 = InputNumber("Введите b2:");
double k2 = InputNumber("Введите k2:");

double x = (b2 - b1) / (k1 - k2);
double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

Console.WriteLine($"Точка пересечения: [{x};{y}]");

