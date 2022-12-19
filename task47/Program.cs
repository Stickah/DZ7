Console.WriteLine("Введите количество строк и столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [m,n];
for (int i = 0; i<array.GetLength(0); i++)
{
for (int j=0; j<array.GetLength(1);j++)
{
array[i,j] = Math.Round( new Random().Next(-100,101)+ new Random().NextDouble(), 2);   
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}