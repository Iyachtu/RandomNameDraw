List<string> InitName = new List<string>() { "Raphael", "Charles", "Vincent", "Yannick", "Solene", "Romain", "Arnaud", "Willy", "Sammy", "Claire", "Laeticia", "Corentin" };
List<string> Noms = new List<string>();
List<string> result = new List<string>();

for (int i = 0; i < 3; i++)
{
    RandomDraw();
    Display();
}

 List<string> RandomDraw()
{
    result.Clear();
    foreach (var item in InitName) Noms.Add(item);
    do
    {
        int number = Draw();
        string a = Noms[number];
        string toadd = a;
        Noms.Remove(a);
        int number2 = Draw();
        string b = Noms[number2];
        toadd = toadd + "/" + b;
        Noms.Remove(b);
        result.Add(toadd);
    } while (Noms.Count > 2);
    string c = Noms[0] + "/" + Noms[1];
    result.Add(c);
    Noms.Clear();
    return result;
}

 int Draw()
{
    int count = Noms.Count;
    Random rng = new Random();
    int Tirage = rng.Next(0, count);

    return Tirage;
}

 void Display()
{
    foreach (var item in result)
    {
        Console.WriteLine(item);
    }
    Console.ReadKey();
    Console.WriteLine("---------------------------");
}