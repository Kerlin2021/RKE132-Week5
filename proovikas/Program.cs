string userPIN, userName, password;

Console.WriteLine ("Enter PIN");
userPIN = Console.ReadLine ();

if(userPIN == "1234")
{

}
else
{
    Console.WriteLine("invalid PIN");
}
Console.WriteLine("Enter your username:");
userName = Console.ReadLine ();
Console.WriteLine("Enter your password:");
password = Console.ReadLine ();

if (userName == "admin1" && password == "admin1234")
{
    Console.WriteLine("Welcome");
}
else
{
    Console.WriteLine("invalid login credentials");
}
