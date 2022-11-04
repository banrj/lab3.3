// 3.3 lab variant 13 Bogomolov Daniil

Console.WriteLine("Введите число n: ");
double limit = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число x: ");
double number = double.Parse(Console.ReadLine());
double sum = 0;

do
{
    if (limit < 1)
    {
        Console.WriteLine("Неверное значение число n > 1\nВведите n: ");
        limit = double.Parse(Console.ReadLine());

    }
    if (number == -1)
    {
        Console.WriteLine("Неверное значение число x != 1\nВведите x: ");
        number = double.Parse(Console.ReadLine());

    }
}
while (limit < 1 || number == -1);

for (int index = 1; index <= limit; index += 2)
{
    Console.WriteLine(index);
    double factor = 1 / index;
    sum += factor * Math.Pow((number - 1) / (number + 1), index);

}
Console.WriteLine($"Total Sum: {sum}");