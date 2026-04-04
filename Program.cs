// task 1
int[] numbers = { 3, 7, 2, 9, 5, 1 };
int sum = 0;
foreach (int number in numbers)
    sum += number;
Console.WriteLine(sum);

// task 2
int[] temps = { 12, -3, 45, 0, 28, -10, 33 };

Array.Sort(temps);

int min = temps[0];
int max = temps[temps.Length - 1];

Console.WriteLine($"min = {min}, max = {max}");

// task 3
string[] words = { "apple", "banana", "cherry", "date" };

for (int i = 0; i < words.Length / 2; i++)
{
    string temp = words[i];
    words[i] = words[words.Length - 1 - i];
    words[words.Length - 1 - i] = temp;
}


Console.WriteLine(string.Join(" ", words));

// task 4
int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };

int even = 0;
int odd = 0;

for (int i = 0; i < data.Length; i++)
{
    if (i % 2 == 0)
    {
        even++;
    }
    else
    {
        odd++;
    }
}


Console.WriteLine("Even = " + even + ", Odd = " + odd);

// task 5

int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };
List<int> unique = new();

foreach (int num in raw)
{
    if (!unique.Contains(num))
        unique.Add(num);
}

int[] result = unique.ToArray();

foreach (int n in result)
    Console.Write(n + " ");

// task 6
int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
int k = 3;

int[] result = RotateLeft(arr, k);

foreach (int x in result)
    Console.Write(x + " ");

static int[] RotateLeft(int[] arr, int k)
{
    k = k % arr.Length;

    int[] result = new int[arr.Length];
    int index = 0;

    for (int i = k; i < arr.Length; i++)
        result[index++] = arr[i];

    for (int i = 0; i < k; i++)
        result[index++] = arr[i];

    return result;
}

// task 7

string s = Console.ReadLine();

Console.WriteLine(IsPalindrome(s));
static bool IsPalindrome(string s)
{
    for (int i = 0; i < s.Length / 2; i++)
    {
        if (s[i] != s[s.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}


// task 8

int n = int.Parse(Console.ReadLine());
Console.WriteLine(Factorial(n));

static long Factorial(int n)
{
    long result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    return result;
}


// task 9

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(FizzBuzz(i));
}

static string FizzBuzz(int n)
{
    if (n % 15 == 0)
        return "FizzBuzz";
    else if (n % 3 == 0)
        return "Fizz";
    else if (n % 5 == 0)
        return "Buzz";
    else
        return n.ToString();
}

// Task 10
double[] celsius = { 0, 20, 37, 100, -40 };
foreach (double c in celsius)
{
    double f = ToFahrenheit(c);
    Console.WriteLine($"{c}°C = {f}°F");
}


static double ToFahrenheit(double c)
{
    return c * 9.0 / 5.0 + 32;
}

static double ToCelsius(double f)
{
    return (f - 32) * 5.0 / 9.0;
}
