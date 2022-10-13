// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int x = 0; 
int y = 1; 
int z = 2;

int Prompt (string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] InputPoint(int point)
{
    int[] result = new int[3];
    result[x] = Prompt($"Введите x {point} = ");
    result[y] = Prompt($"Введите y {point} = ");
    result[z] = Prompt($"Введите z {point} = ");
    return result;
}

int Square(int a)
{
    return a*a;
}

int[] p1 = InputPoint(1);
int[] p2 = InputPoint(2);

double length = Math.Sqrt(Square(p1[x]-p2[x]) + Square(p1[y]-p2[y])+ Square(p1[z]-p2[z]));

System.Console.WriteLine($"{length:f3}");
