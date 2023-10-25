namespace JavaToCSharp;

public class Cat  : Pet, ITalkable
{
    public int MiceKilled { get; set; }

    public Cat( int miceKilled, string name) : base(name)
    {
        MiceKilled = miceKilled;
    }
    public void addMice()
    {
        MiceKilled++;
    }
    
    public string Talk()
    {
        return "Meow";
    }

    public string GetName()
    {
        return Name;
    }
}