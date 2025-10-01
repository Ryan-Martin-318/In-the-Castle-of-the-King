using System.Collections;
bool game = true;
Random random = new Random(); 
int door1 = 0;
int door2 = 0;
int door3 = 0;
//Loops the game, even if the player looses the round
while (game == true)
{
    bool round = true;
    string x = "";
    int door_o = 0;
    int score = 0;
    Console.WriteLine("=========================================\nWelcome to the king's castle, your goal is to try to find the king. However you must be careful not to get eaten by the dragon.");
    while (round == true)
    {
        //assign all the doors diffrent vaules.
        door1 = random.Next(1, 4);
        switch (door1)
        {
            case 1:
                door2 = random.Next(2, 4);
                if (door2 == 2)
                {
                    door3 = 3;
                }
                else
                {
                    door3 = 2;
                }
                break;
            case 2:
                door2 = random.Next(1, 3);
                if (door2 == 1)
                {
                    door3 = 3;
                }
                else
                {
                    door2 = 3;
                    door3 = 1;
                }
                break;
            case 3:
                door2 = random.Next(1, 3);
                if (door2 == 1)
                {
                    door3 = 2;
                }
                else
                {
                    door3 = 1;
                }
                break;
        }
        //The player now has to choose the to go into the three doors.
        Console.Write($"---------------------------\nScore: {score}\nDoors opened {door_o}\nThere are three doors labeled 1, 2, and 3. Which door will you go through. >>");
        int choice = Convert.ToInt32(Console.ReadLine());
        door_o += 1;
        //Variable choice will take on the chosen door's value
        switch (choice)
        {
            case 1:
                choice = door1;
                Console.WriteLine("You chose to go into door #1!");
                break;
            case 2:
                choice = door2;
                Console.WriteLine("You chose to go into door #2!");
                break;
            case 3:
                choice = door3;
                Console.WriteLine("You chose to go into door #3!");
                break;
            default:
                choice = door3;
                Console.WriteLine("You were forced into door #3!");
                break;
        }
        //The program will now look at what choice is and give the opropriate out come.
        switch (choice)
        {
            case 1:
                Console.Write($"You have found the King!!!\nFinal Score: {score}\nDoors Opened: {door_o}\nPlay agian? (y/n) >>");
                x = Console.ReadLine() + "";
                if (x != "y")
                {
                    game = false;
                    Console.Write("Shutting Down . . .");
                }
                break;
            case 2:
                Console.WriteLine("You have found treasure, but there are more doors.");
                score += 1;
                break;
            case 3:
                round = false;
                Console.Write($"You have been eaten by the dragon!!!\nFinal Score: {score}\nDoors Opened: {door_o}\nPlay agian? (y/n) >>");
                x = Console.ReadLine() + "";
                if (x != "y")
                {
                    game = false;
                    Console.Write("Shutting Down . . .");
                }
                break;
        }
    }
}