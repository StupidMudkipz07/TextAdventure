class AdolfKirkResidents : FigthableEntity
{
    public override void Attack(FigthableEntity target)
    {
        target.Hp -= attack;
    }

}
