
abstract class FigthableEntity
{
    public string name;
    public float Hp;
    public float attack;
    public float defense;
    public bool isDefending = false;

    public abstract void Attack(FigthableEntity target);

    public abstract void Defend();

    public abstract void Steal(FigthableEntity target);

    List<Item> inventory;
}