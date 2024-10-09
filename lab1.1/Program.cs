try
{
    Console.WriteLine("Введите трехзначное число");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите b");
    int b = int.Parse(Console.ReadLine());
    int c = x % 10;
    int d = x % 100 / 10;
    int a = x / 100;
    if (a * d * c > b) Console.WriteLine("Больше числа b");
    else Console.WriteLine("Меньше чила b");
    if ((a + b + c) % 3 == 0) Console.WriteLine("Кратно трем");
    else Console.WriteLine("Не кратно трем");
}
catch
{
    Console.WriteLine("Введите корректные данные");
}