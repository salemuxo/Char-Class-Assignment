public class Program
{
    public static void Main(string[] args)
    {
        Character dovahkiin = new("Dovahkiin", "Fus Ro Dah!", "...");
        Character alduin = new("Alduin", "blegh", "argh");

        dovahkiin.Speak(1);
        alduin.SetLevel(2);
        alduin.Speak(2);
    }
}

public class Character
{
    public string Name { get; set; }
    public string Phrase1 { get; set; }
    public string Phrase2 { get; set; }
    public int Level { get; set; }

    public Character(string name, string phrase1, string phrase2)
    {
        Name = name;
        Phrase1 = phrase1;
        Phrase2 = phrase2;
        Level = 0;
    }

    public void Speak(int phraseNum)
    {
        switch (phraseNum)
        {
            case 1:
                Console.WriteLine(Phrase1);
                break;
            case 2:
                Console.WriteLine(Phrase2);
                break;
            default:
                break;
        }
    }

    public void SetLevel(int newLevel)
    {
        Level = newLevel;
        Console.WriteLine("New Level: " + newLevel);
    }
}