Console.Write ("Введите ваше имя: ");
string Username = Console.ReadLine();
if (Username.ToLower() == "маша")
{
    Console.Write ("УРА, Это же МАША");
}
else 
{
    Console.Write ("Привет,");
    Console.WriteLine (Username);
}