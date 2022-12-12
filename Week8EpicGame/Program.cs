

string folderPath = @"C:\\Users\\siimk\\OneDrive\\Desktop\\TKTK\\Programeerimine\\test";
string heroFile = "heroes.txt";
string villianFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villians = File.ReadAllLines(Path.Combine(folderPath, villianFile));


//string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
//string[] villians = { "Voldermort", "Dart Vader", "Dracula", "Joker", "Karen" };


string[] weapon = { "Sword", "Cannon", "Tears", "Lego brick", "magic wand" };

string hero = GetRandomValiueFromArry(heroes);
string heroweapon = GetRandomValiueFromArry(weapon);
Console.WriteLine($"Today {hero} with {heroweapon} saves the day!");


string villian = GetRandomValiueFromArry(villians);
string villianweapon = GetRandomValiueFromArry(weapon);
Console.WriteLine($"Today {villian} with {villianweapon} tries to take over the World!");

static string GetRandomValiueFromArry(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArry = someArray[randomIndex];
    return randomStringFromArry;
}