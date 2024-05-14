namespace Exo_OO_Celsius_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius c = new Celsius();
            c.Temperature = 22;

            Fahrenheit f_from_celsius = c;

            Console.WriteLine($"Il fait actuellement {c.Temperature}°C , aux Etats-unis, ils diraient : {f_from_celsius.Temperature} °F...");

            Fahrenheit f = new Fahrenheit();
            f.Temperature = 64;
            Console.WriteLine($"Il fait actuellement {f.Temperature}°F aux Etats-unis, ici on dirait : {((Celsius)f).Temperature} °C...");
        }
    }
}
