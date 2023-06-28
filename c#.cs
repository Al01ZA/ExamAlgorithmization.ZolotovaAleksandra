using System;
using System.Linq;
class Program
{
    static bool ValidatePassword(string password)
    {
        if (password.Length < 8 || password.Length > 20)
        {
            Console.WriteLine("Пароль должен содержать от 8 до 20 символов");
            return false;
        }
        if (!password.Any(char.IsDigit))
        {
            Console.WriteLine("Пароль должен содержать хотя бы одну заглавную букву");
            return false;
        }
        if (password.All(char.IsLetterOrDigit))
        {
            Console.WriteLine("Пароль должен содержать хотя бы один специальный символ");
            return false;
        }
        return true;
    }
    static void Main(string[] args)
    {
        string password = ("hfFF_3jkf") ;
        bool valid = false;
        do
        {
            Console.Write("Введите пароль: ");
            Console.ReadLine();
            valid = ValidatePassword(password);
        } while (!valid);
        Console.WriteLine("Пароль верный");
    }
}
