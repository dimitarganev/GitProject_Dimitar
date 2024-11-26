using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Прост калкулатор на C#");
        Console.WriteLine("Въведете първото число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Въведете операция (+, -, *, /):");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.WriteLine("Въведете второто число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("Грешка: Деление на нула не е позволено.");
                break;
            default:
                Console.WriteLine("Невалидна операция.");
                break;
        }

        if (operation == '+' || operation == '-' || operation == '*' || (operation == '/' && num2 != 0))
        {
            Console.WriteLine($"Резултат: {num1} {operation} {num2} = {result}");
        }

        Console.WriteLine("Натиснете произволен клавиш за изход...");
        Console.ReadKey();
    }
}
