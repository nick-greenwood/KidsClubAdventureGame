// See https://aka.ms/new-console-template for more information

// This is a boolean variable - which represents if something is 'true' or 'false'
var userHasTakenObject = false;

Console.WriteLine("Welcome to 'Familiar Stuff - Adventure in The Right Way Up'");
Console.WriteLine("This is a thrilling adventure that will test your skills and nerves!");
Console.WriteLine("But first - please tell us your name:");

string? username = Console.ReadLine();

Console.WriteLine($"Great! Welcome, {username} - let's enter The Right Way Up!!!");

IntroScene();
return;

// This function describes the room the player starts in - and gives them some choices on where to go next
void IntroScene()
{
    // Here we are creating a special kind of *VARIABLE* which contains a set of directions the user can go
    // in. This type of *VARIABLE* is a *COLLECTION* (specifically a List in C# terms)
    var validChoices = new List<string> { "Left", "Right", "Forward", "Back" };

    Console.WriteLine("You are in a room that is very dark, with just a single small window letting in a tiny " +
                      "amount of light. You can just make out what looks like a pile of clothes in the corner " +
                      "- from the smell it must be a pile of dirty laundry left by a giant who doesn't wash " +
                      "very much. Let's get out of here! [Left, Right, Back, Forward]");

    var userChoice = string.Empty;

    // Use a while *LOOP* to keep asking the user for their choices until they enter one we recognise
    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        // Here we are using some *CONDITIONAL LOGIC* to check what the user has selected - maybe we can use a neater
        // way to perform this check later?
        if (userChoice == "Left")
        {
            // User has chosen to go left - this takes them to ShowShadowyFigure()
            Console.WriteLine("You chose to go left...");
            ShowShadowyFigure();
        }
        else if (userChoice == "Right")
        {
            // User has chosen to go right - this takes them to ShowSkeletons()
            Console.WriteLine("You chose to go right...");
            ShowSkeletons();
        }
        else if (userChoice == "Back")
        {
            // User has chosen to go back - this takes them to the HauntedRoom()
            Console.WriteLine("You chose to go backwards...");
            HauntedRoom();
        }
        else if (userChoice == "Forward")
        {
            // User has chosen to go forwards - this takes them to a DeadEnd()
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

void ShowShadowyFigure()
{
    var validChoices = new List<string> { "Left", "Right", "Back" };

    Console.WriteLine("You enter a room that looks like it’s made of stars... as you admire how shiny they " +
                      "look a shadowy shape appears – the outline of it looks like a cow but stood on two " +
                      "legs?! What should you do?! [Left, Right, Back]");

    var userChoice = string.Empty;

    // Use a while *LOOP* to keep asking the user for their choices until they enter one we recognise
    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        // Here we are using some *CONDITIONAL LOGIC* to check what the user has selected - maybe we can use a neater
        // way to perform this check later?
        if (userChoice == "Left")
        {
            // User has chosen to go left - this takes them to ShowShadowyFigure()
            Console.WriteLine("You chose to go left...");
            DeadEnd("ShowShadowyFigure");
        }
        else if (userChoice == "Right")
        {
            // User has chosen to go right - this takes them to ShowSkeletons()
            Console.WriteLine("You chose to go right...");
            CameraScene();
        }
        else if (userChoice == "Back")
        {
            // User has chosen to go back - this takes them to the HauntedRoom()
            Console.WriteLine("You chose to go backwards...");
            IntroScene();
        }
        else
        {
            // User has made a mistake - ask them to try again
            Console.WriteLine("I'm not sure where you want to go - please try again");
        }
    }
}

void ShowSkeletons()
{
    var validChoices = new List<string> { "Left", "Back", "Forward" };

    Console.WriteLine("You stumble into the room and trip over what looks like a pile of bones. As you dust " +
                      "yourself off three skeletons spring up from the ground and point at you! " +
                      "What next?! [Left, Back, Forward]");

    var userChoice = string.Empty;

    // Use a while *LOOP* to keep asking the user for their choices until they enter one we recognise
    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        // Here we are using some *CONDITIONAL LOGIC* to check what the user has selected - maybe we can use a neater
        // way to perform this check later?
        if (userChoice == "Left")
        {
            // User has chosen to go left - this takes them to a DeadEnd()
            Console.WriteLine("You chose to go left...");
            DeadEndWithObject();
        }
        else if (userChoice == "Forward")
        {
            // User has chosen to go forward - this takes them to StrangeCreature()
            Console.WriteLine("You chose to go forwards...");
            StrangeCreature();
        }
        else if (userChoice == "Back")
        {
            // User has chosen to go back - this takes them back to the IntroScene()
            Console.WriteLine("You chose to go backwards...");
            IntroScene();
        }
        else
        {
            // User has made a mistake - ask them to try again
            Console.WriteLine("I'm not sure where you want to go - please try again");
        }
    }
}

void CameraScene()
{
    var validChoices = new List<string> { "Back", "Forward" };

    Console.WriteLine("In the middle of this room is an old Polaroid camera. Sticking out of the camera " +
                      "is a photo that is slowly getting clearer. You see that the picture is of you but " +
                      "with a big furry hand on your shoulder! Aaaah! [Back, Forward]");

    var userChoice = string.Empty;

    // Use a while *LOOP* to keep asking the user for their choices until they enter one we recognise
    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        // Here we are using some *CONDITIONAL LOGIC* to check what the user has selected - maybe we can use a neater
        // way to perform this check later?
        if (userChoice == "Forward")
        {
            // User has chosen to go forward - this takes them to the exit to escape!!!
            Console.WriteLine("You chose to go forwards...");
            ExitScene();
        }
        else if (userChoice == "Back")
        {
            // User has chosen to go back - this takes them back to the ShowShadowyFigure()
            Console.WriteLine("You chose to go backwards...");
            ShowShadowyFigure();
        }
        else
        {
            // User has made a mistake - ask them to try again
            Console.WriteLine("I'm not sure where you want to go - please try again");
        }
    }
}

void HauntedRoom()
{
    var validChoices = new List<string> { "Left", "Right", "Back" };

    Console.WriteLine("As you enter this room you feel a real chill in the air… you can see your breath in front of " +
                      "your face. As you look at the grey stone walls you hear a ghostly sound coming out of " +
                      "thin air... 'Oooooh my name is Derek and my back is killing me today! It’s rubbish being a " +
                      "ghost!'. This doesn’t sound good! [Left, Back, Forward]");

    var userChoice = string.Empty;

    // Use a while *LOOP* to keep asking the user for their choices until they enter one we recognise
    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        // Here we are using some *CONDITIONAL LOGIC* to check what the user has selected - maybe we can use a neater
        // way to perform this check later?
        if (userChoice == "Left")
        {
            // User has chosen to go left - this takes them to safety!
            Console.WriteLine("You chose to go left...");
            ExitScene();
        }
        else if (userChoice == "Right")
        {
            // User has chosen to go right - this takes them to a horrible death!
            Console.WriteLine("You chose to go right...");
            DeathScene();
        }
        else if (userChoice == "Back")
        {
            // User has chosen to go back - this takes them back to IntroScene()
            Console.WriteLine("You chose to go backwards...");
            IntroScene();
        }
        else
        {
            // User has made a mistake - ask them to try again
            Console.WriteLine("I'm not sure where you want to go - please try again");
        }
    }
}

void StrangeCreature()
{
    var validChoices = new List<string> { "Fight", "Flight" };

    var sceneMessage = "You emerge into a room that actually looks like a forest – it smells of pine cones " +
                      "and rotten leaves. You hear a screech as a creature that looks half meerkat and " +
                      "half penguin runs towards you. ";

    if (userHasTakenObject)
    {
        validChoices.Add("Use");
        sceneMessage = sceneMessage + "You remember that you picked up a golden feather duster earlier, " +
                       "maybe it will help here? ";
    }

    // This is a bit messy bit it allows us to only add the valid choices to the message the player sees
    sceneMessage = sceneMessage + $"What do you do?! [{string.Join(",", validChoices)}]";
    Console.WriteLine(sceneMessage);

    var userChoice = string.Empty;

    // Use a while *LOOP* to keep asking the user for their choices until they enter one we recognise
    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        // Here we are using some *CONDITIONAL LOGIC* to check what the user has selected - maybe we can use a neater
        // way to perform this check later?
        if (userChoice == "Fight")
        {
            // User has chosen fight - this takes them to a horrible death!
            Console.WriteLine("You chose to fight... you push the MeerGuin and run past it!");
            DeathScene();
        }
        else if (userChoice == "Flight")
        {
            // User has chosen to flight - this takes them to a horrible death!
            Console.WriteLine("You chose to run... I hope the MeerGuin doesn't catch you!");
            DeathScene();
        }
        else if (userChoice == "Use")
        {
            // User has chosen to use the object - tickling always works :)
            Console.WriteLine("You chose to go use the feather duster... you tickle the MeerGuin and he laughs " +
                              "and let's you pass");
            ExitScene();
        }
        else
        {
            // User has made a mistake - ask them to try again
            Console.WriteLine("I'm not sure where you want to do - please try again");
        }
    }
}

void ExitScene()
{
    // The player has got to the exit - they can escape back to Manchester :)
    Console.WriteLine("Running, you enter the next room and see what looks like a window to somewhere" +
                      " grey and rainy - it must be the portal home! You hold your breath and jump towards " +
                      "the window... and find yourself sat in a puddle outside the Arndale Centre. " +
                      "You've made it home! Congratulations player - press [Enter] to play again and see what else " +
                      "The Right Side Up has in store!");
    Console.ReadLine();
    Environment.Exit(0);
}

void DeathScene()
{
    // The player has made a wrong turn - they never made it back home :(
    Console.WriteLine("No one said The Right Way Up would be easy to escape... you take a wrong turn and " +
                      "come across a cute looking Guinea Pig. Unfortunately it is one of the most fearsome " +
                      "creatures in The Right Way Up and with one horrific 'SQUEAK!' your brain is scrambled " +
                      "and all you can think about is lettuce and chew toys. You are stuck here forever! " +
                      "Don't worry though - you can always press [Enter] to play again :)");
    Console.ReadLine();
    Environment.Exit(0);
}

// This is a function that also accepts a *PARAMETER* called 'currentRoom'. Perhaps we can use the value stored in this
// parameter to help the user get back to the room they came from?
void DeadEnd(string currentRoom)
{
    var validChoices = new List<string> { "Back" };

    Console.WriteLine("You have reached a dead end – better turn back [Back]");

    var userChoice = string.Empty;

    // Use a while *LOOP* to keep asking the user for their choices until they enter one we recognise
    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        // Here we are using some *CONDITIONAL LOGIC* to check what the user has selected - maybe we can use a neater
        // way to perform this check later?
        if (currentRoom == "ShowShadowyFigure")
        {
            // User has chosen to go back and came from ShowShadowyFigure - send them back there!
            Console.WriteLine("You chose to go backwards...");
            ShowShadowyFigure();
        } else if (currentRoom == "IntroScene")
        {
            // User has chosen to go back and came from IntroScene - send them back there!
            Console.WriteLine("You chose to go backwards...");
            IntroScene();
        } else if (currentRoom == "ShowSkeletons")
        {
            // User has chosen to go back and came from ShowSkeletons - send them back there!
            Console.WriteLine("You chose to go backwards...");
            ShowSkeletons();
        }
        else
        {
            // User has made a mistake - ask them to try again
            Console.WriteLine("I'm not sure where you want to go - please try again");
        }
    }
}

void DeadEndWithObject()
{
    var validChoices = new List<string> { "Take", "Back" };

    Console.WriteLine("It looks like you have reached a dead end... but you can see a handle sticking " +
                      "out of the wall. You pull it out and find what looks like a golden feather duster " +
                      "in your hand! Could be useful I suppose?! [Take, Back]");

    var userChoice = string.Empty;

    // Use a while *LOOP* to keep asking the user for their choices until they enter one we recognise
    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        if (userChoice == "Take")
        {
            // User has chosen to Take the object - take it and go back ShowSkeletons
            Console.WriteLine("You take the feather duster and head back... it could come in handy!");
            userHasTakenObject = true;
            ShowSkeletons();
        }
        else if (userChoice == "Back")
        {
            // User has chosen to go back and came from ShowSkeletons - send them back there!
            Console.WriteLine("You chose to go backwards...");
            ShowSkeletons();
        }
        else
        {
            // User has made a mistake - ask them to try again
            Console.WriteLine("I'm not sure where you want to go - please try again");
        }
    }
}