
Random choice = new Random();
bool playing = true;
string player;
string computer;


while (playing)
{

    Console.WriteLine("Choose Rock, Paper, or Scissors: ");

    string playerChoice = Console.ReadLine();

    int computerChoice = choice.Next(1, 4);

    switch (computerChoice)
    {
        case 1:
            Console.WriteLine("Computer chose ROCK");
            break;

        case 2:
            Console.WriteLine("Computer chose PAPER");
            break;

        case 3:
            Console.WriteLine("Computer chose SCISSORS");
            break;


    };

    if (playerChoice == "1")
    {
        Console.WriteLine("ROCK");
        break;
    }
    else if (playerChoice == "2")
    {
        Console.WriteLine("PAPER");
        break;
    }
    else
    {
        Console.WriteLine("SCISSORS");
        break;
    }

    Console.WriteLine();

}
NewMethod();

static void NewMethod()
{
    Console.WriteLine("Play Again?");



}
