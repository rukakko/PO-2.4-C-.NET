Console.WriteLine("Task 1: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a == b)
    Console.WriteLine("The numbers are equal");
if (a > b)
    Console.WriteLine("The first number is greater than second number");
else
    Console.WriteLine("The first number is less than second one");



Console.WriteLine("Task 2: ");
int s = Convert.ToInt32(Console.ReadLine());
if (s > 5 && s < 10)
    Console.WriteLine("The number is greater than 5 and less than 10");
else
    Console.WriteLine("Unknown number.");

Console.WriteLine("Task 3: ");
int h = Convert.ToInt32(Console.ReadLine());
if (h == 5 || h == 10)
    Console.WriteLine("The number is either 5 or 10");
else
    Console.WriteLine("Unknown number.");

Console.WriteLine("Task 4: ");
double x = Convert.ToDouble(Console.ReadLine());
if (x < 100)
    x = x + x * 0.05;
else if (x <= 200)
    x = x + x * 0.07;
else
    x = x + x * 0.10;
Console.WriteLine(x);

Console.WriteLine("Task 5: ");
double x1 = Convert.ToDouble(Console.ReadLine());
if (x1 < 100)
    x1 = x1 + x1 * 0.05;
else if (x1 <= 200)
    x1 = x1 + x1 * 0.07;
else
    x1 = x1 + x1 * 0.10;

Console.WriteLine(x1 + 15);

Console.WriteLine("Task 6: ");
Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");

int lol = Convert.ToInt32(Console.ReadLine());
switch (lol)
{
    case 1:
        Console.WriteLine("Addition");
        break;
    case 2:
        Console.WriteLine("Substraction");
        break;
    case 3:
        Console.WriteLine("Multiplication");
        break;
    default:
        Console.WriteLine("Operatuin is undefined");
        break;
}


Console.WriteLine("Task 7: ");
Console.WriteLine("Choose: 1.Addition 2.Subtraction 3.Multiplication. And enter 2 numbers:");
int lolik  = Convert.ToInt32(Console.ReadLine());
double g = Convert.ToDouble(Console.ReadLine());
double v = Convert.ToDouble(Console.ReadLine());
switch (lolik)
{
    case 1:
        Console.WriteLine(g + v);
        break;
    case 2:
        Console.WriteLine(g - v);
        break;
    case 3:
        Console.WriteLine(g * v);
        break;
    default:
        Console.WriteLine("Operation is undefined");
        break;
}