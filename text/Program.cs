Player player = new(){Hp = 40,attack = 6};

player.SetName();

Console.WriteLine("hej " + player.name);
Console.WriteLine("Idag ska du utforska Adolf kirk köping!");
Console.ReadLine();

AdolfKirkResidents anton = new(){Hp = 100, attack = 67,name = "anton"};

Fight köttig = new Fight(player,anton);

köttig.ExecuteFight();

Console.ReadLine();

class S
{
    public static int GetIntFromConsole()
    {
        int output;
        while (!int.TryParse(Console.ReadLine(), out output))
        {
            Console.WriteLine("input is not a integer");
        }
        return output;
    }
    public static int GetIntFromConsole(int minValue, int maxValue)
    {
        int output;
        while (1 == 1)
        {
            if (!int.TryParse(Console.ReadLine(), out output)) Console.WriteLine("input is not a integer");
            else
            {
                if (output > maxValue)
                {
                    Console.WriteLine("input is too big");
                }
                else if (output < minValue)
                {
                    Console.WriteLine("input is too small");
                }
                else return output;
            }
        }
    }

}

