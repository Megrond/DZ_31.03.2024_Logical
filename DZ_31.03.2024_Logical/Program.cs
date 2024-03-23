/*Пользователь вводит в строку с клавиатуры логическое выражение. Например, 3>2 или 7<3.
Программа должна посчитать результат введенного выражения и дать результат true или false.
В строке могут быть только целые числа и операторы: <, >, <=, >=, ==, !=.
Для обработки ошибок ввода используйте механизм исключений.*/

using static System.Console;
class Program
{
    static void Main()
    {
        WriteLine("Введите логическое выражение (например, 3>2 или 7<3):");
        string input = ReadLine();

        try
        {
            bool result = EvaluateExpression(input);
            WriteLine($"Результат: {result}");
        }
        catch (Exception ex)
        {
            WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static bool EvaluateExpression(string input)
    {
        string[] operators = ["==", "!=", "<=", ">=", "<", ">"];

        string[] parts = input.Split(operators, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length != 2)
        {
            throw new ArgumentException("Некорректный формат выражения");
        }

        int number1 = int.Parse(parts[0]);
        int number2 = int.Parse(parts[1]);
        string op = operators.FirstOrDefault(input.Contains);

        switch (op)
        {
            case "==":
                return number1 == number2;
            case "!=":
                return number1 != number2;
            case "<=":
                return number1 <= number2;
            case ">=":
                return number1 >= number2;
            case "<":
                return number1 < number2;
            case ">":
                return number1 > number2;
            default:
                throw new ArgumentException("Неподдерживаемый оператор");
        }
    }
}
