namespace JavaToCSharp;

public class Dog : Pet, ITalkable
{
    public bool Friendly { get; set; }
    public Dog(bool friendly, string name) : base(name)
    {
        Friendly = friendly;
    }

    public bool IsFriendly()
    {
        return Friendly;
    }

    public string Talk()
    {
        return "Bark";
    }

    public string GetName()
    {
        return Name;
    }
}