class Fight
{
    FigthableEntity playerEntity;
    FigthableEntity opponentEntity;
    int turn = 0;

    string[] encounterMessage = new string[5];
    
    FigthableEntity? Winner = null;

    public Fight(FigthableEntity player, FigthableEntity opponent)
    {
        playerEntity = player;
        opponentEntity = opponent;
    }

    bool? AttackTarget(FigthableEntity attcker, FigthableEntity target)
    {
        attcker.Attack(target);
        Console.WriteLine(attcker.name + " attacked " + target.name + " for " + attcker.attack + " damage");
        if (target.Hp <= 0)
        {
            Console.WriteLine(target.name + " was kirked out");
            return true;
        }
        else return false;
    }

    void PrintHp(FigthableEntity player, FigthableEntity opponent)
    {
        Console.WriteLine(player.name + " has " + player.Hp + " health left");
        Console.WriteLine(opponent.name + " has " + opponent.Hp + " health left");

    }

    void StartFight(FigthableEntity player, FigthableEntity opponent)
    {
        Console.WriteLine(opponent.name + " kirkade fram ur skuggorna");
    }

    void RunFight(FigthableEntity player, FigthableEntity opponent)
    {
        while (Winner == null)
        {
            turn++;
            Console.WriteLine("turn: " + turn);
            OpponentChoice(player, opponent);
            PlayerChoice(player, opponent);
        }
        Console.WriteLine("the winner is " + Winner.name);
    }
 
    private void EncounterMessageInit(FigthableEntity player, FigthableEntity opponent)
    {
        for (int i = 0; i < encounterMessage.Length; i++)
        {
            
		}

    }

    public void OpponentChoice(FigthableEntity player, FigthableEntity opponent)
    {

    }

    public void PlayerChoice(FigthableEntity player, FigthableEntity opponent)
    {
		Console.WriteLine("Välj en av de följade.");
		Console.WriteLine("1: Attack\n2: Defend\n3. Steal");
		Console.Write("Val: ");

	    int choicsInt = S.GetIntFromConsole();
	    switch (choicsInt)
	    {
		    case 1:
                if (AttackTarget(player, opponent))
                    Winner = opponent;
                else
                    Winner = player;
                PrintHp(player, opponent);
			    break;
		    case 2:
                player.Defend();
			    break;
		    case 3:
			    break;
		    default:
				break;
		}

        

    }

	public void ExecuteFight()
    {
		StartFight(playerEntity, opponentEntity);
		RunFight(playerEntity, opponentEntity);
    }
}