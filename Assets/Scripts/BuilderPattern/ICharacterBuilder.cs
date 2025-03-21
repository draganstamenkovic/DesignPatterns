namespace DesignPatterns.Builder
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetHealth(float health);
        Character Build();
    }
}
