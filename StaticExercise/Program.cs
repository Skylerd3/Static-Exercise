namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("After Conversionse:");

            var Celsius = TempConverter.FahrenheitToCelsius(68);
            Console.WriteLine($"Celsius: {Celsius}");


            var Fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"Fahrenheit: {Fahrenheit}");

            
        }

    }
}
