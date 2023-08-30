// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to 'Familiar Stuff - Adventure in The Right Way Up'");
Console.WriteLine("This is a thrilling adventure that will test your skills and nerves!");
Console.WriteLine("But first - please tell us your name:");

var username = Console.ReadLine() ?? string.Empty;

Console.WriteLine($"Great! Welcome, {username} - let's enter The Right Way Up!!!");

IntroScene();
return;

// Here we tweak the code a bit to use a "switch" statement to tidy the conditionals a bit. We also handle
// the user typing the right command in a different case than we expect
void IntroScene(string currentRoom = "")
{
    var validChoices = new List<string> { "Left", "Right", "Back", "Forward" };
    
    Console.WriteLine("You are in a room that is very dark, with just a single small window letting in a tiny " +
                      "amount of light. You can just make out what looks like a pile of clothes in the corner " +
                      "- from the smell it must be a pile of dirty laundry left by a giant who doesn't wash " +
                      "very much. Let's get out of here! [Left, Right, Back, Forward]");

    string userChoice;

    do
    {
        userChoice = Console.ReadLine() ?? string.Empty;
        
        switch (userChoice.ToUpper())
        {
            case "LEFT":
                // User has chosen to go left - this takes them to ShowShadowyFigure()
                Console.WriteLine("You chose to go left...");
                ShowShadowyFigure("IntroScene");
                break;
            case "RIGHT":
                // User has chosen to go right - this takes them to ShowSkeletons()
                Console.WriteLine("You chose to go right...");
                ShowSkeletons("IntroScene");
                break;
            case "BACK":
                // User has chosen to go back - this takes them to the HauntedRoom()
                Console.WriteLine("You chose to go backwards...");
                HauntedRoom("IntroScene");
                break;
            case "FORWARD":
                // User has chosen to go forwards - this takes them to a DeadEnd()
                Console.WriteLine("You chose to go forwards...");
                DeadEnd(currentRoom: "IntroScene");
                break;
            default:
                // User has made a mistake - ask them to try again
                Console.WriteLine("I'm not sure where you want to go - please try again");
                break;
        }
        
    } while (!validChoices.Contains(userChoice, StringComparer.OrdinalIgnoreCase));
}

// This example uses a Dictionary to store all the valid options which is a bit neater
void ShowShadowyFigure(string currentRoom)
{
    var sceneMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "Left", "DeadEnd" },
        { "Right", "CameraScene" },
        { "Back", "IntroScene" },
    };
    
    Console.WriteLine("You enter a room that looks like it’s made of stars... as you admire how shiny they look a " +
                      "shadowy shape appears – the outline of it looks like a cow but stood on two legs?! What " +
                      "should you do?! [Left, Right, Back]");

    string userChoice;

    do
    {
        userChoice = Console.ReadLine() ?? string.Empty;

        if (sceneMap.TryGetValue(userChoice, out var nextRoom))
        {
            Console.WriteLine($"You chose to go {userChoice}...");

            switch (nextRoom)
            {
                case "DeadEnd":
                    DeadEnd("IntroScene");
                    break;
                case "CameraScene":
                    CameraScene("IntroScene");
                    break;
                case "IntroScene":
                    IntroScene("IntroScene");
                    break;
                default:
                    // User has made a mistake - ask them to try again
                    Console.WriteLine("I'm not sure where you want to go - please try again");
                    break;
            }
        }
        
    } while (!sceneMap.ContainsKey(userChoice));
}

void ShowSkeletons(string currentRoom)
{
    // Why don't you try and write some code that will;
    // -- Describe the room that the user is now in and where they can go next
    // -- Capture what they want to do next
    // -- Take the user to the next room based on what they chose
    throw new NotImplementedException();
}

void HauntedRoom(string currentRoom)
{
    // Why don't you try and write some code that will;
    // -- Describe the room that the user is now in and where they can go next
    // -- Capture what they want to do next
    // -- Take the user to the next room based on what they chose
    throw new NotImplementedException();
}

// This is a function that also accepts a *PARAMETER* called 'currentRoom'. Perhaps we can use the value stored in this
// parameter to help the user get back to the room they came from?
void DeadEnd(string currentRoom)
{
    // Why don't you try and write some code that will;
    // -- Tell the user they have reached a dead end and where they can go next (only back!)
    // -- Capture what they want to do next
    // -- Take the user back to the last room they came from (could the 'currentRoom' *PARAMETER* help with this?)
    throw new NotImplementedException();
}

// This is a function that also accepts a *PARAMETER* called 'currentRoom'. Perhaps we can use the value stored in this
// parameter to help the user get back to the room they came from?
void CameraScene(string currentRoom)
{
    // Why don't you try and write some code that will;
    // -- Tell the user they have reached a dead end and where they can go next (only back!)
    // -- Capture what they want to do next
    // -- Take the user back to the last room they came from (could the 'currentRoom' *PARAMETER* help with this?)
    throw new NotImplementedException();
}