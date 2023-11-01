using System;

public class Math
{
    public void Add(double a, double b)
    {
        double result = a + b;
        Console.WriteLine($"Результат сложения: {result}");
    }

    public void Subtract(double a, double b)
    {
        double result = a - b;
        Console.WriteLine($"Результат вычитания: {result}");
    }

    public void Multiply(double a, double b)
    {
        double result = a * b;
        Console.WriteLine($"Результат умножения: {result}");
    }

    public void Divide(double a, double b)
    {
        if (b != 0)
        {
            double result = a / b;
            Console.WriteLine($"Результат деления: {result}");
        }
        else
        {
            Console.WriteLine("Деление на ноль невозможно.");
        }
    }
}

class Program
{
    static void Main()
    {
        Math math = new Math();

        double num1 = 10;
        double num2 = 5;

        math.Add(num1, num2); // Вывод: "Результат сложения: 15"
        math.Subtract(num1, num2); // Вывод: "Результат вычитания: 5"
        math.Multiply(num1, num2); // Вывод: "Результат умножения: 50"
        math.Divide(num1, num2); // Вывод: "Результат деления: 2"
    }
}
