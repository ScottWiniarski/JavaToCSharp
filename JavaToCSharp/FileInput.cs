namespace JavaToCSharp;

public class FileInput
{
     public void ReadFile(string[] input)
     {
          try
          {
               //Console.WriteLine("hello");
               input.ToList().ForEach(n => Console.WriteLine(n));
          }
          catch(Exception ex)
          {
               Console.WriteLine("Exception Thrown: " + ex);
          }
          
     }
     
     
}


     
     /*StreamReader sr = new StreamReader("animals.txt");
    
     Lines = File.ReadAllLines("animals.txt"));*/


