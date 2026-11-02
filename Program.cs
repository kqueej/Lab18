// Part 1

int Gcd(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }

    return a;
}

int Lcm(int a, int b)
{
    return a / Gcd(a, b) * b;
}
Console.WriteLine($"НОД(48, 18) = {Gcd(48, 18)}");
Console.WriteLine($"НОК(48, 18) = {Lcm(48, 18)}");

Console.WriteLine($"НОД(12, 8) = {Gcd(12, 8)}");
Console.WriteLine($"НОК(12, 8) = {Lcm(12, 8)}");

Console.WriteLine($"НОД(7, 13) = {Gcd(7, 13)}");
Console.WriteLine($"НОК(7, 13) = {Lcm(7, 13)}");

Console.WriteLine($"НОД(100, 25) = {Gcd(100, 25)}");
Console.WriteLine($"НОК(100, 25) = {Lcm(100, 25)}");

// Алгоритм останавливается при b == 0, т.к остаток от деления равен 0, a становится НОД

// Part 2
bool IsPrime(int number)
{
    if (number < 2)
        return false;

    for (int i = 2; i * i <= number; i++)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}

int[] numbers = { 1, 2, 17, 18, 97, 0, -5 };

foreach (int number in numbers)
{
    Console.WriteLine($"{number}: {IsPrime(number)}");
}

// Достаточно проверять делители, до квадратного корня числа, т.к больший делитель обязательно имеет парный меньший делитель
