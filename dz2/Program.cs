Console.WriteLine("Введите координаты первой точки");
int X1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
int X2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double H = Math.Sqrt ((X2-X1)*(X2-X1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1) );

Console.WriteLine($"Рассточние между точками равно {H}");
