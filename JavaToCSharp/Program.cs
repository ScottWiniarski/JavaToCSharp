// See https://aka.ms/new-console-template for more information

using System.Collections;
using JavaToCSharp;

string filePath = "C:/Users/Owner/RiderProjects/MobileApplications/JavaToCSharp/animals.txt";

string fileName = "animals.txt";
//string filePath = Path.GetFullPath(fileName).Replace(@"\", "/");
string fullPath = Path.GetFullPath(fileName).Replace(@"\", "/");
Console.WriteLine("GetFullPath('{0} returns '{1}'", fileName, fullPath);
Console.WriteLine(fullPath.Replace(@"\", "/"));
string[] newFilePath = File.ReadAllLines(fullPath);
foreach (string file in newFilePath)
{
    Console.WriteLine(file);
}

// TODO User Input section - calls upon user to enter data
ITalkable userInput;
UserChoice askUser = new UserChoice();
userInput = askUser.UserObject();

List<ITalkable> zoo = new List<ITalkable>();
zoo.Add(new Dog(true,"Bean"));
zoo.Add(new Cat(9,"Charlie"));
zoo.Add(new Teacher(65,"Matt Green"));
zoo.Add(userInput);


// TODO - Writes data to file
FileOutput writeFile = new FileOutput();
List<string> output = new List<string>();
foreach (ITalkable item in zoo)
{
    printOut(item);
}
writeFile.WriteFile(filePath, output);

    void printOut(ITalkable p)
{
    Console.WriteLine(p.GetName() + " says= " + p.Talk());
    output.Add($"{p.GetName()} | {p.Talk()}" ) ;
    
}

// TODO - Reads data from file
string[] readLineByLine = File.ReadAllLines(filePath);
FileInput readFile = new FileInput();
readFile.ReadFile(readLineByLine);

