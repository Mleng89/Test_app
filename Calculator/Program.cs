Console.Write("Enter a number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter your operator from (+, -, *, /): ");
string? op = Console.ReadLine();

Console.Write("Enter another number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

static double calculate(double num1, double num2, string op)
{
    //int result;
    if(op == "+")
    {
        return num1 + num2;
    } else if( op == "-")
    {
        return num1 - num2;
    }
    else if(op == "*")
    {
        return num1 * num2;
    } else if(op == "/")
    {
        return num1 / num2;
    }
        return 0.0;
};

Console.WriteLine(calculate(num1, num2, op));