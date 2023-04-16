namespace SchoolActivities;

/**
 * 06 Quiz 1
 * @author Peter John Arao
 */
public static class App
{
    public static void Main()
    {
        Console.WriteLine("Problem Number 1");
        FirstProblem();
        Console.WriteLine();
        Console.WriteLine("Problem Number 2");
        SecondProblem();
        Console.WriteLine();
        Console.WriteLine("Problem Number 3");        
        ThirdProblem();
    }

    private static void FirstProblem()
    {
        string[] classmates = {
            "Adrian Embellado", 
            "Ian Carl Azupardo",
            "Misha Nicole Galan",
            "Gerard Bongaos",
            "Clarence Vega",
            "Zyra Joy Maquiniana"
        };
        Console.WriteLine("|-------------------|");
        Console.WriteLine("|   My Classmates   |");
        Console.WriteLine("|-------------------|");
        foreach (var classmate in classmates)
        {
            Console.WriteLine(classmate);
        }
        Console.WriteLine("|-------------------|");
    }
    
    private static void SecondProblem()
    {
        char[,] lettersInTheAlphabet = {
            {'A', 'B', 'C'}, 
            {'D', 'E', 'F'}
        };
        
        Console.WriteLine("|-----------------|");
        Console.WriteLine("| First 6 letters |");
        Console.WriteLine("| in the alphabet |");
        Console.WriteLine("|-----------------|");
        foreach (var letter in lettersInTheAlphabet)
        {
            Console.WriteLine(letter);
        }
        Console.WriteLine("|-----------------|");

    }
    
    private static void ThirdProblem()
    {
        const string message = "C# programming is a popular language used for developing a variety of applications, \n" +
                               "including web and desktop applications, games, and mobile apps. \n" +
                               "One of the most fundamental concepts in C# programming is the use of variables to store and manipulate data. \n" +
                               "With C#, you can create complex programs that interact with databases, utilize APIs, and perform complex calculations. \n" +
                               "Additionally, C# offers powerful object-oriented programming features such as inheritance, \n" +
                               "encapsulation, and polymorphism that enable developers to create reusable and maintainable code. \n" +
                               "Overall, C# is a versatile language that can help you say \"hello\" to the world of software development.";
        const string toFind = "hello";
        var doesContainHello = message.Contains(toFind);
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Does the message contains {toFind}: {doesContainHello}");
    }
}