﻿// See https://aka.ms/new-console-template for more information

using System.Collections;
using JavaToCSharp;

string filePath = "C:/Users/Owner/RiderProjects/MobileApplications/JavaToCSharp/animals.txt";

List<ITalkable> zoo = new List<ITalkable>();
zoo.Add(new Dog(true,"Bean"));
zoo.Add(new Cat(9,"Charlie"));
zoo.Add(new Teacher(65,"Matt Green"));

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

/*string fileName = "animals.txt";
string fullPath = Path.GetFullPath(fileName);
Console.WriteLine("GetFullPath('{0} returns '{1}'", fileName, fullPath);
string[] fileByContentLine = File.ReadAllLines("C:/Users/Owner/RiderProjects/MobileApplications/JavaToCSharp/animals.txt");
string[] fileByContentLine = File.ReadAllLines(fullPath.Replace(@"\\", "/"));*/

// TODO - Reads data from file
string[] readLineByLine = File.ReadAllLines(filePath);
FileInput readFile = new FileInput();
//readFile.ReadFile(fileByContentLine);
readFile.ReadFile(readLineByLine);

