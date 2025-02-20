namespace StaticExercise
{
    public static class TempConverter
	{
		public static double FahrenheitToCelsius(double Fahrenheit)
		{

			return  (Fahrenheit - 32) / 1.8;

			
		}
		public static double CelsiusToFahrenheit(double Celsius)
		{
			return (Celsius * 9) / 5 + 32;
		}
	}
}

