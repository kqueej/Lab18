// Part 1

// int Gcd(int a, int b)
// {
//     while (b != 0)
//     {
//         int temp = b;
//         b = a % b;
//         a = temp;
//     }

//     return a;
// }

// int Lcm(int a, int b)
// {
//     return a / Gcd(a, b) * b;
// }
// Console.WriteLine($"НОД(48, 18) = {Gcd(48, 18)}");
// Console.WriteLine($"НОК(48, 18) = {Lcm(48, 18)}");

// Console.WriteLine($"НОД(12, 8) = {Gcd(12, 8)}");
// Console.WriteLine($"НОК(12, 8) = {Lcm(12, 8)}");

// Console.WriteLine($"НОД(7, 13) = {Gcd(7, 13)}");
// Console.WriteLine($"НОК(7, 13) = {Lcm(7, 13)}");

// Console.WriteLine($"НОД(100, 25) = {Gcd(100, 25)}");
// Console.WriteLine($"НОК(100, 25) = {Lcm(100, 25)}");

// Алгоритм останавливается при b == 0, т.к остаток от деления равен 0, a становится НОД

// Part 2
// bool IsPrime(int number)
// {
//     if (number < 2)
//         return false;

//     for (int i = 2; i * i <= number; i++)
//     {
//         if (number % i == 0)
//             return false;
//     }

//     return true;
// }

// int[] numbers = { 1, 2, 17, 18, 97, 0, -5 };

// foreach (int number in numbers)
// {
//     Console.WriteLine($"{number}: {IsPrime(number)}");
// }

// Достаточно проверять делители, до квадратного корня числа,
// т.к больший делитель обязательно имеет парный меньший делитель


// Part 3
// int[] values = { 5, 2, 5, 3, 2, 5, 4, 3, 3 };

// Dictionary<int, int> counts = new Dictionary<int, int>();

// foreach (int number in values)
// {
//     if (counts.ContainsKey(number))
//         counts[number]++;
//     else
//         counts[number] = 1;
// }

// foreach (var pair in counts)
// {
//     Console.WriteLine($"{pair.Key} -> {pair.Value}");
// }

// Один раз просматриваю массив, это банально эффективнее и меньше ресурсов забирает

// Part 4
// int calls = 0;

// int Fibonacci(int n)
// {
//     calls++;

//     if (n <= 1)
//         return n;

//     return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// Console.WriteLine($"Fibonacci(10) = {Fibonacci(10)}");
// Console.WriteLine($"Вызовов: {calls}");

// calls = 0;

// Console.WriteLine($"Fibonacci(20) = {Fibonacci(20)}");
// Console.WriteLine($"Вызовов: {calls}");

// Рекурсивный алгоритм повторно вычисляет одинаковые значения, из-за чего кол-во вызовов кратно увеличивается


// Final task
int[] values = { 12, 15, 12, 7, 19, 15, 12, 8, 7, 19 };

int FindMin(int[] numbers)
{
    int min = numbers[0];

    foreach (int number in numbers)
    {
        if (number < min)
            min = number;
    }

    return min;
}

int FindMax(int[] numbers)
{
    int max = numbers[0];

    foreach (int number in numbers)
    {
        if (number > max)
            max = number;
    }

    return max;
}

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

Dictionary<int, int> CountFrequencies(int[] numbers)
{
    Dictionary<int, int> counts = new Dictionary<int, int>();

    foreach (int number in numbers)
    {
        if (counts.ContainsKey(number))
            counts[number]++;
        else
            counts[number] = 1;
    }

    return counts;
}

int min = FindMin(values);
int max = FindMax(values);

Dictionary<int, int> frequencies = CountFrequencies(values);

Console.WriteLine(string.Join(" ", values));

Console.WriteLine($"min: {min}");
Console.WriteLine($"max: {max}");

Console.WriteLine($"Count: {frequencies.Count}");

Console.WriteLine("freq:");

List<int> keys = new List<int>(frequencies.Keys);
keys.Sort();

foreach (int key in keys)
{
    Console.WriteLine($"{key} -> {frequencies[key]}");
}

Console.WriteLine($"GCD({min}, {max}): {Gcd(min, max)}");

Console.WriteLine($"{min} - {(IsPrime(min) ? "prime" : "composite")} number");
Console.WriteLine($"{max} - {(IsPrime(max) ? "prime" : "composite")} number");