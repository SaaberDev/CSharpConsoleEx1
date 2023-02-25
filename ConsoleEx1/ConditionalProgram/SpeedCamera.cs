namespace ConsoleEx1.ConditionalProgram;

public class SpeedCamera
{
    public void DetermineSpeedLimitViolation()
    {
        Action<int, int> displayCurrentDemeritPoint = (current, limit) =>
        {
            Console.WriteLine($"Your current demerit point is {current}/{limit}.");
        };

        Console.WriteLine("Please enter a speed limit.");
        var speedLimit = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please enter the speed of your car.");
        var carSpeed = Convert.ToInt16(Console.ReadLine());

        const int kmLimit = 5;
        const int demeritLimit = 12;

        // if -- enters a value LESS THAN the SPEED LIMIT => returns "ok"
        if (carSpeed < speedLimit)
        {
            Console.WriteLine("Nice, you are under speed limit.");
            Console.WriteLine($"Current speed is {carSpeed}/{speedLimit}.");
        }
        else
        {
            Console.WriteLine("WARNING, slow down buddy, you are speeding.");
            Console.WriteLine($"Current speed is {carSpeed}/{speedLimit}.");

            // if -- value is ABOVE the SPEED LIMIT => calculate the number of demerit points (for EVERY 5km/hr ABOVE the SPEED LIMIT [1 demerit points should be incurred and displayed on the console])
            var currentDemeritPoint = (carSpeed - speedLimit) / kmLimit;
            displayCurrentDemeritPoint(currentDemeritPoint, demeritLimit);

            // if -- DEMERIT points is ABOVE 12 => returns "License Suspended"
            if (currentDemeritPoint <= demeritLimit) return;
            Console.WriteLine("Your License has been SUSPENDED due to speeding.");
            displayCurrentDemeritPoint(currentDemeritPoint, demeritLimit);
        }
    }
}