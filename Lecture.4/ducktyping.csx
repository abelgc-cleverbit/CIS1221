// use csi to interactively run this file
// use #load "ducktyping.csx" to dynamically load defintions in this file
// then try: 
//  var du = new RealDuck();
//  var hu = new HumanWithDuckInstincts();
//  fly_quack(du);
//  fly_quack(hu);
// Define the IDuck interface with fly and quack methods
public interface IDuck
{
    void fly();
    void quack();
}

// Implement the IDuck interface in a class
// Implement the IDuck interface in a class
public class RealDuck : IDuck
{
    public void fly()
    {
        Console.WriteLine("Flying like a real duck");
    }

    public void quack()
    {
        Console.WriteLine("Quacking like a real duck");
        if (OperatingSystem.IsWindows())
            Console.Beep(1000, 500); // Frequency 1000 Hz, Duration 500 ms
    }
}

// Implement the IDuck interface in another class
public class RobotDuck : IDuck
{
    public void fly()
    {
        Console.WriteLine("Flying like a robot duck");
    }

    public void quack()
    {
        Console.WriteLine("Quacking like a robot duck");
        if (OperatingSystem.IsWindows())
            Console.Beep(500, 500); // Frequency 500 Hz, Duration 500 ms
    }
}

// Implement the IDuck interface in a class that mimics a duck
public class HumanMimickingDuck : IDuck
{
    public void fly()
    {
        Console.WriteLine("Spreading my arms to flap like a duck");
    }

    public void quack()
    {
        Console.WriteLine("Trying to quack like a duck");
        if (OperatingSystem.IsWindows())
        {
            Console.Beep(1500, 500); // Frequency 1500 Hz, Duration 500 ms
        }
    }
}
// Method that accepts any object implementing the IDuck interface
static void fly_quack(IDuck d)
{
    d.fly();
    d.quack();
}

// Pond class that contains an array of IDuck objects and simulates random quacking
public class Pond
{
    private IDuck[] ducks;

    public Pond()
    {
        // Create an array of 20 different IDuck objects
        ducks = new IDuck[20];
        for (int i = 0; i < ducks.Length; i++)
        {
            if (i % 3 == 0)
                ducks[i] = new RealDuck();
            else if (i % 3 == 1)
                ducks[i] = new RobotDuck();
            else
                ducks[i] = new HumanMimickingDuck();
        }
    }

    // Method that makes a random selection of ducks quack
    public void random_quack()
    {
        Random random = new Random();
        for (int i = 0; i < 50; i++)
        {
            int index = random.Next(ducks.Length);
            ducks[index].quack();
            int waitTime = random.Next(30, 801);
            System.Threading.Thread.Sleep(waitTime);
        }
    }

    // Method to start the simulation
    public void simulate()
    {
        Console.WriteLine("Starting the duck pond simulation...");
        random_quack();
        Console.WriteLine("Simulation ended.");
    }
}

// Main method to demonstrate the use of interfaces
public static void Main()
{
    // Create instances of different classes implementing IDuck
    IDuck realDuck = new RealDuck();
    IDuck robotDuck = new RobotDuck();
    IDuck humanMimickingDuck = new HumanMimickingDuck();

    // Call the fly_quack method with different implementations
    fly_quack(realDuck);
    fly_quack(robotDuck);
    fly_quack(humanMimickingDuck);

    // Advantages:
    // 1. Flexibility: We can pass any object that implements the IDuck interface to the fly_quack method.
    // 2. Code Reusability: We can reuse the fly_quack method for different implementations of IDuck.
    // 3. Abstraction: We can work with the interface without worrying about the specific implementation details.

    // Disadvantages:
    // 1. Overhead: Interfaces can add a slight overhead due to the indirection.
    // 2. Complexity: Using interfaces can make the code more complex and harder to understand for beginners.
    // 3. Maintenance: Changes to the interface may require changes to all implementing classes.


    Console.WriteLine();
    Console.WriteLine("Press any key to run pond example");
    Console.ReadKey();

    // Create an instance of Pond and start the simulation
    Pond pond = new Pond();
    pond.simulate();

    Console.WriteLine();
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
}






// Call the Main method to run the example
//Main();