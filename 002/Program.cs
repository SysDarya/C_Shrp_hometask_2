// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.

int a = new Random().Next (100, 1000);
Console.WriteLine ($"Случайно сгенерированное число: {a}.");

    int last = a % 10;
    int first = a / 100;
    int mid = (a/10) % 10;
    int res = first * 10 + last;

    Console.WriteLine ($"Вторая цифра данного числа равна {mid}. Получившееся число равно {res}.");
    
    // Ещё был вариант без ввода новой переменной:
    // Console.WriteLine ($"Вторая цифра данного числа равна {mid}. Получившееся число равно {first}{last}.");