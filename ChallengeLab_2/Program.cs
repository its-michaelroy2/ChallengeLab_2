namespace ChallengeLab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ChallengeLab_2:");
            Console.WriteLine("===============\n");

            Console.WriteLine("Enter the temperature in Fahrenheit:");
            if (double.TryParse(Console.ReadLine(), out double temperature))
            {
                string message = GetTemperatureMessage(temperature);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static string GetTemperatureMessage(double temperature)
        {
            if (temperature <= 10)
                return "Freezing weather";
            else if (temperature <= 20)
                return "Very Cold weather";
            else if (temperature <= 35)
                return "Cold weather";
            else if (temperature <= 50)
                return "Normal in Weather";
            else if (temperature <= 65)
                return "Its Hot";
            else if (temperature <= 80)
                return "Its Very Hot";
            else
                return "Extremely Hot";
        }
    }
}