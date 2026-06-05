namespace Exercice;

// receive a value in seconds and converts to: hours, minutes and seconds.

public class Convertor_time
{
    
    public static (int, int, int) ConvertSeconds(int totalSeconds)
    {
        if (totalSeconds < 0)
        {
            throw new ArgumentException("The total seconds cannot be negative.");
        }

        int hours = totalSeconds / 3600;
        int minutes = (totalSeconds % 3600) / 60;
        int seconds = totalSeconds % 60;

        //Console.WriteLine($"{totalSeconds} seconds is equal to {hours} hours, {minutes} minutes and {seconds} seconds.");

        return (hours, minutes, seconds);
    }

}