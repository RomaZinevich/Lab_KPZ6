using task2;

public class Program
{
    static void Main(string[] args)
    {
        CommandCentre commandCentre = new CommandCentre(new Runway[0], new Aircraft[0]);
        Runway[] runways = new Runway[] { new Runway(1, commandCentre), new Runway(2, commandCentre) };
        Aircraft[] aircrafts = new Aircraft[] { new Aircraft("Boeing 747", commandCentre), new Aircraft("Airbus A380", commandCentre) };

        commandCentre = new CommandCentre(runways, aircrafts);

        aircrafts[0].Land();
        aircrafts[1].Land();
        Console.WriteLine();
        aircrafts[0].TakeOff();
        aircrafts[1].TakeOff();
    }
}

