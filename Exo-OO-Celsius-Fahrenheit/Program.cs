namespace Exo_OO_Celsius_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius c;
            c.temperature = 22;

            Console.WriteLine($"Il fait actuellement {c.temperature}°C , aux Etats-unis, ils diraient : {c.ToFahrenheit().temperature} °F...");
        }
    }
}
