
using System;
using GeometryLibrary;
using TextProcessingLibrary;
using ValidationLibrary;
using FileSystemLibrary;

class Program
{
    static void Main()
    {
        // Тест GeometryLibrary
        Console.WriteLine("Площадь квадрата (сторона 5): " + Geometry.SquareArea(5));
        Console.WriteLine("Площадь прямоугольника (5x10): " + Geometry.RectangleArea(5, 10));
        Console.WriteLine("Площадь треугольника (основание 6, высота 4): " + Geometry.TriangleArea(6, 4));

        // Тест TextProcessingLibrary
        string text = "А роза упала на лапу Азора";
        Console.WriteLine($"Текст '{text}' палиндром? {TextProcessor.IsPalindrome(text)}");
        Console.WriteLine("Количество предложений: " + TextProcessor.SentenceCount("Привет! Как дела? Всё хорошо."));
        Console.WriteLine("Переворот строки: " + TextProcessor.ReverseString("Hello World"));

        // Тест ValidationLibrary
        Console.WriteLine("ФИО корректно? " + Validator.IsValidName("Иван Иванов"));
        Console.WriteLine("Возраст корректен? " + Validator.IsValidAge("25"));
        Console.WriteLine("Телефон корректен? " + Validator.IsValidPhone("+79161234567"));
        Console.WriteLine("Email корректен? " + Validator.IsValidEmail("test@example.com"));

        // Тест FileSystemLibrary
        string testFile = "asd.txt";
        string copiedFile = "copy_test.txt";
        FileManager.CopyFile(testFile, copiedFile);
        Console.WriteLine("Файл скопирован");

        string reportFile = "report.txt";
        FileManager.SearchWordInFile(testFile, "asd", reportFile);
        Console.WriteLine("Поиск слова завершён, результаты в report.txt");
    }
}
