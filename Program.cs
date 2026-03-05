class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> cookies = new Dictionary<string, string>();

        cookies["user"] = "Couto";
        cookies["email"] = "couto@email.com";
        cookies["phone"] = "(11)998765432";

        cookies["user"] = "Hugo";
        cookies["email"] = "hugo@email.com";
        cookies["phone"] = "(11)912345678";



        foreach (KeyValuePair<string, string> item in cookies)
        {
            System.Console.WriteLine($"{item.Key} => {item.Value}");
        }
    }
}