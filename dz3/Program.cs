// 
Console.WriteLine("Введите число N");
int A = Convert.ToInt32(Console.ReadLine());
if (A<=0)
{
    Console.WriteLine("Нет");
}

else 
{

for (int i = 1; i<=A; i++ )
{
    int B = i*i*i;
    Console.WriteLine(B);
}
}