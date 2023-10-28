namespace JavaToCSharp;

public class FileOutput
{
    public void WriteFile(string filePath, List<string> output)
    {
        try
        {
            
            File.WriteAllLines(filePath, output);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Write Exception Thrown: " + ex);
        }
    }
}