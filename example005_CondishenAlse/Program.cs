Console.Write("Введите имя пользователя!");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, к нам счастье привалило, это же Машка -промокашка");
}
else
{
    Console.Write("Здрасьте,  ");
    Console.WriteLine(username);
}