//Check for correct input
double distance = 0, timeTakenSeconds = 0;
try
{
    Console.Write("Please input a distance in meters: ");
    distance = int.Parse(Console.ReadLine());

    //Converting the time to seconds after input and adding it up.

    Console.Write("Please input hours taken: ");
    timeTakenSeconds = int.Parse(Console.ReadLine()) * 3600;
    Console.Write("Please input minutes taken: ");
    timeTakenSeconds += int.Parse(Console.ReadLine()) * 60;
    Console.Write("Please input seconds taken: ");
    timeTakenSeconds += int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Please input only whole numbers!");
    return;
}

//Calculations for m/s, km/h and mph.
double metersPerSec, kilometersPerHour, milesPerHour;

metersPerSec = distance / timeTakenSeconds;
kilometersPerHour = metersPerSec * 3.6;
milesPerHour = kilometersPerHour / 1.609;

//Output
Console.WriteLine("Meters per second: " + metersPerSec);
Console.WriteLine("Kilometers per hour: " + kilometersPerHour);
Console.WriteLine("Miles per hour: " + Math.Round(milesPerHour, 5));



