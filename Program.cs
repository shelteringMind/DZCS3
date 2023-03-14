//*/
//Задача 19

string ReadNum(string text)
{
    System.Console.Write(text);
    return Console.ReadLine()!;
}

void pаlindrom(string number)
{
    for (int i = 0; i <= number.Length / 2; i++)
    {
        if (number[i] != number[number.Length - i - 1])
        {
            Console.Write("Введенное число не является палиндромом!");
            return;
        }
    }
    Console.Write($"{number} является палиндромом!");
    return;
}

string pal = ReadNum("Введите пятизначное число: ");
if (pal.Length == 5)
{
    pаlindrom(pal);
}
else
{
    Console.Write("Вы ввели число, отличающееся от требуемого!");
}