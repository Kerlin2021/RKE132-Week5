//Math >=90; Bio >= 90; Chem >=90

using System.Transactions;

int math, bio, chem;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your bio results:");
bio = Int32.Parse(Console.ReadLine());
    
Console.WriteLine("Enter your chem results:");
chem = Int32.Parse(Console.ReadLine());

if(math >= 90 && bio >= 90 && chem >= 90)
{
    Console.WriteLine("Õnnitleme! Olete sisse pääsenud!");
}
else
{
    Console.WriteLine("Tulemused ei olnud piisavad!");
}