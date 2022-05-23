// Задайте массив по вормуле А = м+n

int m = 4, n = 3;
int[,] mass = new int [m, n];
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = i + j;
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
