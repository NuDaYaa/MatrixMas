Random r = new Random();
int row = r.Next(3, 9); 
int col = r.Next(3, 9);
int[,] matrix = new int[row, col];

Console.WriteLine($"Исходная матрица {row}x{col}: \n");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        matrix[i, j] = r.Next(1, 100);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");
Console.WriteLine("Массив сумм строк: \n");
int[] MassivSum = new int[row];
for (int i = 0; i < row; i++)
{
    int sum = 0;
    for (int j = 0; j < col; j++)
    {
        sum += matrix[i, j];
    }
    MassivSum[i] = sum;
}
for (int i = 0; i < row; i++)
{
    Console.Write(MassivSum[i] + " ");
}
Console.ReadLine();
