string name = GetName();
DateTime date = DateTime.Now;

Menu(name);

static void AdditionGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    int score = 0;

    int firstNumber;
    int secondNumber;

    Console.WriteLine("How many problems would you like to solve?");
    int numberOfProblems = int.Parse(Console.ReadLine());

    for(int i = 0; i < numberOfProblems; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"\n{firstNumber} + {secondNumber}");
        string result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("\nCorrect Answer!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect Answer!");
        }
    }
    Console.WriteLine($"Your score is {score}");
}

static void SubtractionGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    int score = 0;
    int firstNumber;
    int secondNumber;

    Console.WriteLine("How many problems would you like to solve?");
    int numberOfProblems = int.Parse(Console.ReadLine());

    for(int i =0; i < numberOfProblems;i++)
    {
        firstNumber= random.Next(1, 9);
        secondNumber= random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        int answer = int.Parse(Console.ReadLine());

        if (answer == firstNumber - secondNumber)
        {
            Console.WriteLine("\nCorrect Answer!");
            score++;
        } else
        {
            Console.WriteLine("Incorrect Answer!");
        }
    }
    Console.WriteLine($"Your score is {score}");
}

static void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    int score = 0;
    int firstNumber;
    int secondNumber;

    Console.WriteLine("How many problems would you like to solve?");
    int numberOfProblems = int.Parse(Console.ReadLine());

    for (int i = 0; i < numberOfProblems; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        int answer = int.Parse(Console.ReadLine());

        if (answer == firstNumber * secondNumber)
        {
            Console.WriteLine("\nCorrect Answer!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect Answer!");
        }
    }
    Console.WriteLine($"Your score is {score}");
}

static void DivisionGame(string message)
{
    Console.WriteLine(message);
}

 void Menu(string name)
{
    Console.WriteLine("----------------------------------");
    Console.WriteLine($"Hey there {name}. It is {date}. Welcome to the math game!\n");
    Console.WriteLine(@$"Which method would you like your game to be? Choose an option below: 
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the game");
    Console.WriteLine("----------------------------------");

    string gameSelected = Console.ReadLine().Trim().ToLower();

    switch (gameSelected)
    {
        case "a":
            AdditionGame("Addition selected\n");
            break;
        case "s":
            SubtractionGame("Subtraction selected!\n");
            break;
        case "m":
            MultiplicationGame("Multiplication selected!\n");
            break;
        case "d":
            DivisionGame("Division selected!\n");
            break;
        case "q":
            Console.WriteLine("Game left!\n");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid input!!\n");
            Environment.Exit(0);
            break;
    }
}

static string GetName()
{
    Console.WriteLine("Please type your name: ");

    string name = Console.ReadLine();
    return name;
}