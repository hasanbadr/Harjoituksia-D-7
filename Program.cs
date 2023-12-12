using System;

class Program
{
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 1.8) + 32;
    }

    static void Main()
    {
        Console.Write("Syötä Celsius-asteet: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = CelsiusToFahrenheit(celsius);
        Console.WriteLine($"Fahrenheit: {fahrenheit}");
    }
}
