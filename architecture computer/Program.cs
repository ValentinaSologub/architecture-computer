using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number: ");
        int decimalNumber = int.Parse(s: Console.ReadLine());

        // Перевести в двійкову систему (P = 2)
        string binaryResult = DecimalToBaseP(decimalNumber, 2);
        Console.WriteLine($"In the binary system: {binaryResult}");

        // Перевести в вісімкову систему (P = 8)
        string octalResult = DecimalToBaseP(decimalNumber, 8);
        Console.WriteLine($"In octal system: {octalResult}");

        // Перевести в шістнадцяткову систему (P = 16)
        string hexadecimalResult = DecimalToBaseP(decimalNumber, 16);
        Console.WriteLine($"In hexadecimal: {hexadecimalResult}");
    }

    static string DecimalToBaseP(int number, int baseP)
    {
        string result = "";
        while (number > 0)
        {
            int remainder = number % baseP;
            if (remainder < 10)
                result = remainder.ToString() + result;
            else
                result = (char)(remainder - 10 + 'A') + result;
            number = number / baseP;
        }
        return result;
    }
}
