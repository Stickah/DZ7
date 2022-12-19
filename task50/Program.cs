Console.WriteLine("Введите количество строк и столбцов в массиве");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [m,n];
Random rnd = new Random();
for (int i = 0; i<array.GetLength(0); i++)
{
for (int j=0; j<array.GetLength(1);j++)
{
array[i,j] = rnd.Next(-100,101);   
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}
 Console.WriteLine("Введите позицию элемента в массиве");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 void PrintElement(int [,] array)
 {
 for (int i = 0; i<array.GetLength(0); i++)
    for (int j=0; j<array.GetLength(1);j++)
        if ( j==b && i==a)
            Console.WriteLine($"это число {array [a,b]} ");
 }
if (a>=array.GetLength(0) || b>=array.GetLength(1))
    Console.WriteLine("такого числа нет");
else  PrintElement(array);