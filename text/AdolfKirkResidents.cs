class AdolfKirkResidents : FigthableEntity
{
    public override void Attack(FigthableEntity target)
    {
		if (target.isDefending)
			target.defense *= 2;

		if (target.defense >= attack)
			target.Hp--;
		else
			target.Hp -= attack - target.defense;

		if (target.isDefending)
		{
			target.defense /= 2;
			target.isDefending = false;
		}
	}

	public override void Defend()
	{
		isDefending = true;
	}

	public override void Steal(FigthableEntity target)
	{
		throw new NotImplementedException();
	}

}
