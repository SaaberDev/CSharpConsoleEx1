namespace ConsoleEx1.ConditionalProgram;

internal class ImageDisplayRecognition
{
    public void DisplayOrientation()
    {
        Console.WriteLine("Enter a width.");
        var width = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter a height.");
        var height = Convert.ToInt16(Console.ReadLine());

        var display = width > height ? "Landscape" : "Portrait";

        Console.WriteLine($"The image is in {display} mode.");
    }
}