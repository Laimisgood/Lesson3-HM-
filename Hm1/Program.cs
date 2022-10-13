// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не применять строки!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool Condition(int num)
{
    if (num >= 10000 && num < 100000)
    {
        return true;
    }
    return false;
}

int num = Prompt("Введите пятизначное число: ");

int digitCount = (int)Math.Log10(num) + 1;
int first = num / 10000 % 10;
int second = num / 1000 % 10;
int beforeLast = num / 10 % 10;
int last = num % 10;

if (Condition(num))
{
    if (first == last)
    {
        if (second == beforeLast)
        {
            System.Console.WriteLine($"Число {num} является палиндромом");
        }
    }
    else
    {
        System.Console.WriteLine($"Число {num} не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Введено не пятизначное число, попробуйте заново");
}
