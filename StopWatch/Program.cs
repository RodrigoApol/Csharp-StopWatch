namespace StopWatch;
class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("S = Segundos");
        Console.WriteLine("M = Minutos");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("");
        Console.Write("Digite o tempo: ");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplier = 1;

        if (type == 'm')
            multiplier = 60;

        if (type == 0)
            Environment.Exit(0);

        PreStart(time * multiplier);
    }

    static void PreStart(int time)
    {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.WriteLine("Go...");
        Thread.Sleep(1000);

        Start(time);
    }

    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        End();
    }

    static void End()
    {
        Console.Clear();
        Console.WriteLine("StopWatch finalizado.");
        Thread.Sleep(2500);
        Menu();
    }
}
