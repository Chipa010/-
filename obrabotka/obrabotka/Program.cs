using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число для деления на 100:");

        try
        {
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput); // Попытка преобразовать ввод в целое число
            int result = 100 / number; // Деление на введенное число
            Console.WriteLine($"Результат деления: 100 / {number} = {result}.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Ошибочка: на нолик нельзя делить к сожалению!.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ошибочка: введите другое число!!!.");
        }
        catch (Exception ex) // Обработка всех остальных исключений
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Всё чётко, спасибо!");
        }
    }
}