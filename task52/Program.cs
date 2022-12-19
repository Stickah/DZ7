Console.WriteLine("Введите количество строк и столбцов в массиве");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [m,n];
Random rnd = new Random();
for (int i = 0; i<array.GetLength(0); i++)
{
     for (int j=0; j<array.GetLength(1);j++)
     {array[i,j] = rnd.Next(0,10);   
      Console.Write($"{array[i,j]} ");
     }
Console.WriteLine();
}
Console.WriteLine("---");
int k = 0;
while (k<array.GetLength(1))
{double sum = 0;
    for (int c = 0; c<array.GetLength(0); c++)
        sum+= array[c,k];
Console.Write($"{Math.Round(sum/m,2)}; ");       
k+=1;
}