Player player = new(){Hp = 40,attack = 6};

player.SetName();

Console.WriteLine("hej " + player.name);
Console.WriteLine("Idag ska du utforska Adolf kirk köping!");
Console.ReadLine();

AdolfKirkResidents anton = new(){Hp = 100, attack = 67,name = "anton"};

Fight köttig = new Fight(player,anton);

köttig.ExecuteFight();

Console.ReadLine();

