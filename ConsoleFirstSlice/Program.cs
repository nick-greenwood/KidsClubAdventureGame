// See https://aka.ms/new-console-template for more information

// This is an example of a *LOOP*. As the condition always evaluates to 'true' it will run until we explicitly
// tell it to stop!

// The 'Console.WriteLine' command is some C# code that helps us print out text to the screen
Console.WriteLine("Welcome to 'My First Adventure Game - Pretty Boring'");
Console.WriteLine("This is a not so thrilling adventure that will not test your skills or nerves very much!");
Console.WriteLine("But first - please tell us your name:");

// Declare a *VARIABLE* to store the user input
var username = Console.ReadLine();

// Write out a message to the screen to welcome them to the game
Console.WriteLine($"Great! Welcome, {username} - let's go!!!");

IntroScene();
return;

// This is an example of a *FUNCTION* - functions allow us to group code statements together, which we can then
// tell our program to use at the right time
void IntroScene()
{
    // Here we are creating a *VARIABLE* that will hold the valid direction the user can go - don't worry we'll
    // make the game more interesting soon!
    var validDirection = "Forward";

    Console.WriteLine("You are in a murky room that smells of fish which has only one door out. I guess you'll" +
                      " have to go through it! [Forward]");

    // Here we are creating a *VARIABLE* that will hold the users' choice
    var userChoice = string.Empty;

    // Use a while *LOOP* to keep asking the user for their choice until they enter one we recognise
    while (userChoice != validDirection)
    {
        userChoice = Console.ReadLine();

        // Here we are using some *CONDITIONAL LOGIC* to check what the user has selected - maybe we can find a neater
        // way to perform this check later?

        if (userChoice == "Forward")
        {
            // User has chosen to go forward - this takes them to a DeadEnd()
            Console.WriteLine("You chose to go forwards...");
            DeadEnd(currentRoom: "IntroScene");
        }
        else
        {
            // User has made a mistake - ask them to try again
            Console.WriteLine("I'm not sure where you want to go - please try again");
        }
    }
}

// This is a function that also accepts a *PARAMETER* called 'currentRoom'. Perhaps we can use the value stored in this
// parameter to help the user get back to the room they came from?
void DeadEnd(string currentRoom)
{
    var validDirection = "Back";

    Console.WriteLine("You have reached a dead end – better turn back [Back]");

    var userChoice = string.Empty;

    while (userChoice != validDirection)
    {
        userChoice = Console.ReadLine();

        if (userChoice == "Back")
        {
            if (currentRoom == "IntroScene")
            {
                IntroScene();
            }
            else
            {
                Console.WriteLine("I don't know where you came from... but now you're stuck until you expire from boredom!");
                break;
            }
        }
        else
        {
            Console.WriteLine("I don't understand that choice - please try again");
        }
    }
}