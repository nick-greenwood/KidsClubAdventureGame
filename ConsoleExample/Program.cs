WriteDescription("Welcome to 'Familiar Stuff - Adventure in The Right Way Up'");
WriteDescription("This is a thrilling adventure that will test your skills and nerves!");
WriteDescription("But first - please tell us your name:");

var username = Console.ReadLine();
bool hasRabiesInjection = false;
bool hasRadioActiveSuit = false;
bool hasSword = false;
bool hasFuel = false;
bool hasMoney = false;

WriteDescription($"Great! Welcome, {username} - let's enter The Right Way Up!!!");

IntroScene();
return;

void IntroScene()
{
    var validChoices = new List<string> { "Left", "Right", "Forward", "Back" };

    WriteDescription("You are in a room that smells of dry lemon. " +
                      "There is a pile of dry lemons in the corner. " +
                      "You can choose to go: [L]eft, [R]ight, [B]ack, [F]orward");

    var userChoice = string.Empty;

    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        if (MatchesUserChoice(userChoice, "Left"))
        {
            WriteChoice("You chose to go left...");
            RabidHorseRoom();
        }
        else if (MatchesUserChoice(userChoice, "Right"))
        {
            WriteChoice("You chose to go right...");
            FuelAndMoneyRoom();
        }
        else if (MatchesUserChoice(userChoice, "Back"))
        {
            WriteChoice("You chose to go backwards...");
            VeryHauntedByMichaelJacksonRoom();
        }
        else if (MatchesUserChoice(userChoice, "Forward"))
        {
            WriteChoice("You chose to go forwards...");
            DeadEnd();
        }
        else
            WriteError("I'm not sure where you want to go - please try again");
    }
}

void RabidHorseRoom()
{
    var validChoices = new List<string> { "Forward", "Right" };

    if (!hasRabiesInjection)
        EndGame("You are in a room with a rabid horse. YOU DIE of rabies!");

    WriteDescription("You are in a room with a rabid horse. " +
                     "You catch rabies. " +
                     "You use your rabies injection and survive. " +
                     "You can choose to go: [F]orward, [R]ight");

    var userChoice = string.Empty;

    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        if (MatchesUserChoice(userChoice, "Forward"))
        {
            WriteChoice("You chose to go forward...");
            ExitScene();
        }
        else if (MatchesUserChoice(userChoice, "Right"))
        {
            WriteChoice("You chose to go right...");
            IntroScene();
        }
        else
            WriteError("I'm not sure where you want to go - please try again");
    }
}

void FuelAndMoneyRoom()
{
    var validChoices = new List<string> { "Pick up fuel", "Pick up money", "Forward", "Back", "Left" };

    WriteDescription("You are standing in a dark room. " +
                     "There is a spotlight shining on a briefcase of money, next to this is a can of diesel. " +
                     "You can choose to: [L]eft, [F]orward, Pick up f[U]el, Pick up [M]oney");

    var userChoice = string.Empty;

    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        if (MatchesUserChoice(userChoice, "Left"))
        {
            WriteChoice("You chose to go left...");
            IntroScene();
        }
        else if (MatchesUserChoice(userChoice, "Pick up money", "M"))
        {
            hasMoney = true;
            userChoice = "";
            WriteChoice("You have picked up the money....");
        }
        else if (MatchesUserChoice(userChoice, "Pick up fuel", "U"))
        {
            hasFuel = true;
            userChoice = "";
            WriteChoice("You have picked up the fuel....");
        }
        else if (MatchesUserChoice(userChoice, "Forward"))
        {
            WriteChoice("You chose to go forwards...");
            UtilityRoom();
        }
        else if (MatchesUserChoice(userChoice, "Back"))
        {
            WriteChoice("You chose to go back...");
            RadioActiveRoom();
        }
        else
            WriteError("I'm not sure where you want to go - please try again");
    }
}

void VeryHauntedByMichaelJacksonRoom()
{
    var validChoices = new List<string> { "Left", "Right", "Forward" };

    WriteDescription("You scream because you see a ghost! " +
                     "The ghost of Michael Jackson! He Heeeee. " +
                     "You can choose to: [L]eft, [R]ight, [F]orward, [M]oonwalk");

    var userChoice = string.Empty;

    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        if (MatchesUserChoice(userChoice, "Left"))
        {
            WriteChoice("You chose to go left...");
            EndGame("You get covered in batter and deep fried. YOU DIE!");
        }
        else if (MatchesUserChoice(userChoice, "Right"))
        {
            WriteChoice("You chose to go right...");
            RadioActiveRoom();
        }
        else if (MatchesUserChoice(userChoice, "Moonwalk"))
        {
            WriteChoice("You chose to moonwalk...");
            EndGame("You are now stuck on the south pole of the moon. THE END!");
        }
        else if (MatchesUserChoice(userChoice, "Forward"))
        {
            WriteChoice("You chose to go forwards...");
            IntroScene();
        }
        else
            WriteError("I'm not sure where you want to go - please try again");
    }
}

void UtilityRoom()
{
    var validChoices = new List<string> { "Back" };

    WriteDescription("You are standing in a utility room! " +
                     "There is a radioactive suit and a sword. " +
                     "You can choose to: Pick up [R]adioactive suit, Pick up [S]word, [B]ack");

    var userChoice = string.Empty;

    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        if (MatchesUserChoice(userChoice, "Pick up radioactive suit", "R"))
        {
            hasRadioActiveSuit = true;
            userChoice = "";
            WriteChoice("You have picked up the radioactive suit....");
        }
        else if (MatchesUserChoice(userChoice, "Pick up sword", "S"))
        {
            hasSword = true;
            userChoice = "";
            WriteChoice("You have picked up the sword....");
        }
        else if (MatchesUserChoice(userChoice, "Back"))
        {
            WriteChoice("You chose to go back...");
            FuelAndMoneyRoom();
        }
        else
            WriteError("I'm not sure where you want to go - please try again");
    }
}

void RadioActiveRoom()
{
    var validChoices = new List<string> { "Left", "Right", "Forward" };

    if (hasRadioActiveSuit)
    {
        WriteDescription("You are in a bright yellow room! " +
                         "You survive as you are wearing the radioactive suit! " +
                         "You can choose to go: [L]eft, [R]ight, [F]orward");
    }
    else
        EndGame("You DIE of radiation.");

    var userChoice = string.Empty;

    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        if (MatchesUserChoice(userChoice, "Left"))
        {
            WriteChoice("You have decided to go left...");
            VeryHauntedByMichaelJacksonRoom();
        }
        if (MatchesUserChoice(userChoice, "Right"))
        {
            WriteChoice("You have decided to go right...");
            VaccineRoom();
        }
        if (MatchesUserChoice(userChoice, "Forward"))
        {
            WriteChoice("You have decided to go forward...");
            FuelAndMoneyRoom();
        }
        else
            WriteError("I'm not sure where you want to go - please try again");
    }
}

void DeadEnd()
{
    var validDirection = "Back";

    WriteDescription("You have reached a dead end – better turn back [B]ack");

    var userChoice = string.Empty;

    while (userChoice != validDirection)
    {
        userChoice = Console.ReadLine();

        if (MatchesUserChoice(userChoice, "Back"))
            IntroScene();
        else
            WriteError("I don't understand that choice - please try again");
    }
}

void ExitScene()
{
    if (hasFuel)
    {
        WriteDescription("Frank says 'You can come with me as you have the fuel, but you must cook the spaghetti correctly'. " +
                         "You can choose to: [B]reak spaghetti, [D]on't break spaghetti");

        var spaghettiInput = Console.ReadLine();

        if (MatchesUserChoice(spaghettiInput, "Break spaghetti"))
            EndGame("You cooked the spaghetti wrong. Frank KILLS YOU!");
        else if (MatchesUserChoice(spaghettiInput, "Don't break spaghetti"))
            WinGame("You survived. YOU WIN! GAME OVER!");
        else
            EndGame("Frank doesn't like your response. Frank KILLS YOU!");
    }
    else
    {
        WriteError("Frank says 'You need to come back with fuel'.");
        RabidHorseRoom();
    }
}

void VaccineRoom()
{
    var validChoices = new List<string> { "Left", "Pick up vaccine" };

    WriteDescription("You are standing in a pure white room. " +
                     "There is a needle on the table containing green liquid. " +
                     "You can choose to: [L]eft, Pick up [V]accine");

    var userChoice = string.Empty;

    while (validChoices.Contains(userChoice) == false)
    {
        userChoice = Console.ReadLine();

        if (MatchesUserChoice(userChoice, "Left"))
            RadioActiveRoom();
        else if (MatchesUserChoice(userChoice, "Pick up vaccine", "V"))
        {
            hasRabiesInjection = true;
            userChoice = "";
            WriteChoice("You have picked up the rabies vaccine....");
        }
        else if (MatchesUserChoice(userChoice, "Back"))
        {
            WriteChoice("You chose to go back...");
            FuelAndMoneyRoom();
        }
        else
            WriteError("I'm not sure where you want to go - please try again");
    }
}

void WinGame(string text)
{
    Write(text, ConsoleColor.Green);
    Environment.Exit(0);
}

void EndGame(string text)
{
    WriteError(text);
    Environment.Exit(0);
}

bool MatchesUserChoice(string input, string expected, string? custom = null)
{
    return expected.Equals(input, StringComparison.InvariantCultureIgnoreCase)
           || (custom ?? expected[0].ToString()).Equals(input, StringComparison.InvariantCultureIgnoreCase);
}

void WriteError(string text) => Write(text, ConsoleColor.Red);
void WriteDescription(string text) => Write(text);
void WriteChoice(string text) => Write(text, ConsoleColor.Blue);

void Write(string text, ConsoleColor colour = ConsoleColor.Yellow)
{
    Console.ForegroundColor = colour;
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.White;
}