// See https://aka.ms/new-console-template for more information

int playerNumber;
int enemyNumber;
int playerScore = 0;
int enemyScore = 0;

//Creating a random type object
Random random = new Random();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Press any key to roll the dice !");
    Console.ReadKey();

    //Next(1, 7) its a method allowing us to give the range we want [1;7) - first element its inclusive, second its exclusive
    playerNumber = random.Next(1, 7);
    Console.WriteLine($"You rolled a : {playerNumber} ");

    //Mimic a period of time (1000 miliseconds =1 second) for the other number to be generated
    Console.WriteLine("----");
    System.Threading.Thread.Sleep(1000);

    enemyNumber = random.Next(1, 7);
    Console.WriteLine($"The computer rolled a : {enemyNumber} ");

    if (playerNumber > enemyNumber)
    {
        playerScore++;
    }
    else if (playerNumber < enemyNumber)
    {
        enemyScore++;
    }
    else
    {
        Console.WriteLine("It's a draw !!!");
    }
    Console.WriteLine($"PLAYER score is : {playerScore} and ENEMY score is : {enemyScore}");
    Console.WriteLine();
}

if (playerScore > enemyScore)
{
    Console.WriteLine(" ---YOU WON THE GAME !!!---");
}
else if (playerScore < enemyScore)
{
    Console.WriteLine(" --- YOU LOSE THE GAME :( ---");
}
else
{
    Console.WriteLine("YOU AND THE COMPUTER ARE EQUALS, ITS A TIE !");
}
