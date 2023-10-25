namespace JavaToCSharp;

public abstract class Pet
{
    private string _name;

    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            _name = Name;
        }
    }

    public Pet(string name)
    {
        Name = name;
    }
}