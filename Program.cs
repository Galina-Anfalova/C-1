//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.Через строку решать нельзя.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*Console.WriteLine("ВВедите число");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num;
int count = 0;
int res = 0;
while (num > 0)
{
    count++;
    num = num / 10;
}

if (count < 3) Console.WriteLine($"{num2} -> Третьей цифры нет");
else
{
    for (int k = 0; k < 3; k++)
    {
        count -= 1;
        int j = 0, b = 1, a = 10, n = count;
        while (j != n)
        {
            j++;
            b *= a;

        }
        res = num2 / b;

    }
    Console.WriteLine($"{num2} -> {res % 10}");
}*/

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе
//показывает вторую цифру этого числа. Через строку решать нельзя.

//456 -> 5
//782 -> 8
//918 -> 1

/*Console.WriteLine("ВВедите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Число не трёхзначное, введите повторно");
    return;
}
int a = number / 10 % 10;
Console.WriteLine("Вторая цифра:" + a);*/

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt16(Console.ReadLine());
switch (number)
{
    case 1:
    Console.WriteLine("Понедельник");
    break;

    case 2:
    Console.WriteLine("Вторник");
    break;

    case 3:
    Console.WriteLine("Среда");
    break;

    case 4:
    Console.WriteLine("Четверг");
    break;

    case 5:
    Console.WriteLine("Пятница");
    break;

    case 6:
    Console.WriteLine("Суббота");
    break;

    case 7:
    Console.WriteLine("Воскресенье");
    break;

    default:
    Console.WriteLine("Введён не тот номер недели");
    break;
}
if (number <= 7)
{
    if (number < 6)
    {
        Console.WriteLine("К сожалению придётся поработать");
    }
    else
    {
        Console.WriteLine("Ура, выходной!!!");
    }
}