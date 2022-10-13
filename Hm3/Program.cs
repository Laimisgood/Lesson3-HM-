// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int Prompt (string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int N = Prompt("Введите число N = ");

for (int count = 1; count <= N; count++)
{
    System.Console.WriteLine(Math.Pow(count, 3));
}
