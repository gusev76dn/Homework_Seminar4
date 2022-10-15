// задача 29

Console.WriteLine("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите max: ");
int maxA = Convert.ToInt32(Console.ReadLine());
int maxN = maxA + 1;

int[] array = new int [N];
Random myRandom = new Random();

for(int i = 0; i < N; i++)
{
    if (i == 0)
    {
        array[i] = myRandom.Next(min, maxN);
        Console.Write("[" + array[i]);
    }
    else if (i < N)
    {
        array[i] = myRandom.Next(min, maxN);
        Console.Write("," + array[i]);
    } 
}
Console.Write("]");