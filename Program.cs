
using System.Text;

Random random = new Random();
bool playAgain = true;
String player ;
String computer;
String answer;

while (playAgain) 
{ 
    player = "";
    computer = "";
    answer = "";

    while (player != "ROCK" && player != "PAPPER" && player != "SCISSORS")
    {
        Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
        player = Console.ReadLine();
        player = player.ToUpper();
    }

    switch (random.Next(0,3)) 
    {
        case 0: computer = "ROCK"; break;
        case 1: computer = "PAPER"; break;
        case 2: computer = "SCISSORS"; break;
    }

    Console.WriteLine("Player: " + player);
    Console.WriteLine("Computer: " + computer);

    switch (player) 
    {
        case "ROCK": 
            if (computer == "ROCK") {
                Console.WriteLine("It's a Draw!"); 
            }else if(computer == "PAPER") {
                Console.WriteLine("You Lost!"); 
            }else if(computer == "SCISSORS") {
                Console.WriteLine("You Win!"); 
            };
                break;
        case "PAPER": 
            if (computer == "ROCK") {
                Console.WriteLine("You Win!"); 
            }else if(computer == "PAPER") {
                Console.WriteLine("It's a Draw!"); 
            }else if(computer == "SCISSORS") {
                Console.WriteLine("You Lost!"); 
            }; break;
        case "SCISSORS": 
            if (computer == "ROCK") {
                Console.WriteLine("You Lost!"); 
            }else if(computer == "PAPER") {
                Console.WriteLine("You Win!"); 
            }else if(computer == "SCISSORS") {
                Console.WriteLine("It's a Draw!"); 
            }; break;
    }

    Console.Write("Would you like to play again (Y/N): ");
    answer = Console.ReadLine().ToUpper();

    if(answer == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
    }
}

Console.WriteLine("Thanks for playing!");
