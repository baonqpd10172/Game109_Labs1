using System;


public static class UserData
{
    public static string id;
    public static string userName;
    public static float gold;
    public static int point;

    static UserData()
    {
        id = "1st";
        userName = "first";
        gold = 0;
        point = 0;
    }
    public static void ShowData()
    {
        Console.WriteLine("Id:" + id);
        Console.WriteLine("UserName:" + userName);

    }

}
public class Program
{
    public static int Main(string[] args)
    {
        UserData.ShowData();
        return 0;
    }
}

