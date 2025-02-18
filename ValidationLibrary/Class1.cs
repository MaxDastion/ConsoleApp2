using System;
using System.Text.RegularExpressions;

namespace ValidationLibrary
{
    public static class Validator
    {
        public static bool IsValidName(string name) => Regex.IsMatch(name, "^[a-zA-Zа-яА-Я /s]+$");
        public static bool IsValidAge(string age) => int.TryParse(age, out _);
        public static bool IsValidPhone(string phone) => Regex.IsMatch(phone, "^ /+?[0-9]{10,15}$");
        public static bool IsValidEmail(string email) => Regex.IsMatch(email, "^[/w.-]+@[/w.-]+/.[a-zA-Z]{2,}$");
    }
}
