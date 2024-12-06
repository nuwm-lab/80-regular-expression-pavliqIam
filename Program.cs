using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Тут є декілька номерів телефонів: 1234567, 7654321, але також є інші номери 9876543 і 12345, які не є 7-значними.";

        // Регулярний вираз для пошуку 7-значних номерів телефонів
        string pattern = @"\b\d{7}\b";

        // Використовуємо Regex для пошуку всіх 7-значних номерів у тексті
        MatchCollection matches = Regex.Matches(text, pattern);

        // Виводимо знайдені номери
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
