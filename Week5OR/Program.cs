//math >=90 or Chem>=90 or bio >=

// math && chem || math && bio || chem && bio

int math, bio, chem;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your bio results:");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chem results:");
chem = Int32.Parse(Console.ReadLine());

if(( math >= 90&& chem >=90) || (math >=90 && bio >=90) || (chem>=90 && bio >=90))
{
    Console.WriteLine("Õnnitleme! Olete sisse pääsenud!");
}
else
{
    Console.WriteLine("Tulemused ei olnud piisavad!");
}