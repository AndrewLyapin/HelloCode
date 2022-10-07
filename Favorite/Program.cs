Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "андрей")
{
    Console.WriteLine("Ура, ты тут!");
}
else 
{
    Console.Write("Ну, привет, ");
    Console.Write(username.ToUpper());  
}