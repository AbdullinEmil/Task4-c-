/// task num 4
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите математическое выражение: ");
        string expression = Console.ReadLine();
        try
        {
            int result = CalculateExpression(expression);
            Console.WriteLine("Результат: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка ввода: " + ex.Message);
        }
    }

    static int CalculateExpression(string expression) 
    {
        string[] numbers = expression.Split('*'); /// разбивает исходную строку expression на массив строк numbers, используя символ '' как разделитель
            int result = 1;
        foreach (string number in numbers) ///foreach - итеративно перебирает каждый элемент массива numbers
        {
            result *= int.Parse(number); ///Внутри цикла, мы преобразуем строку number в целое число с помощью int.Parse(number) и умножаем result на это число
        }
        return result; ///функция возвращает результат
    }
}