/*/
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
//*/

/*/
//Задача 21

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double [] A=new double[3];
double [] B=new double[3];

A[0] = ReadInt("Введите координату x точки A: ");
B[0] = ReadInt("Введите координату x точки B: ");
A[1] = ReadInt("Введите координату y точки A: ");
B[1] = ReadInt("Введите координату y точки B: ");
A[2] = ReadInt("Введите координату z точки A: ");
B[2] = ReadInt("Введите координату z точки B: ");

double dist(double[] a,double[] b) {
    double d = 0;
    d = Math.Sqrt(Math.Pow((b[0]-a[0]),2) + Math.Pow((b[1]-a[1]),2) + Math.Pow((b[2]-a[2]),2));
    return d;
}

System.Console.Write(dist(A,B));
//*/

//*/
//Задача 23

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] cubeNumber(int n)
{
    int k = 1;
    if (n < 0) k = (int)Math.Pow(-1, 3);
    n = Math.Abs(n);
    int[] table = new int[n + 1];

    for (int i = 1; i <= n; i++)
    {
        table[i - 1] = (int)Math.Pow(i, 3) * k;
    }
    return table;
}

int n = ReadInt("Введите число: ");
int m = Math.Abs(n);
int[] tableCube = new int[m + 1];
System.Console.Write($"{n} -> ");
tableCube = cubeNumber(n);
for (int i = 1; i <= m; i++)
{
    System.Console.Write($"{tableCube[i - 1]}");
    if (i < m) System.Console.Write(", ");
}
//*/