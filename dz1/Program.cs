Console.WriteLine("Введите пятизначное число");
int H = Convert.ToInt32(Console.ReadLine());

int A = H/10000;
int B = H/1000%10;
int D = H/10%10;
int E = H%10;

// Console.WriteLine(A);
// Console.WriteLine(B);
// Console.WriteLine(D);
// Console.WriteLine(E);

if (H<10000 || H>99999)
{
    Console.WriteLine("Введено неверное число");
}

else if (A==E && B==D)
{
    Console.WriteLine("Палиндром");
}

else
{
    Console.WriteLine("Не палиндром");
}