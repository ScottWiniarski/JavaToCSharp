namespace JavaToCSharp;

public abstract class Person
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

    public Person(string name)
    {
        Name = name;
    }
}