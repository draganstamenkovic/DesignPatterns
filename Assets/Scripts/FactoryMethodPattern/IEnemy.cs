namespace DesignPatterns.FactoryMethod
{
    public interface IEnemy
    {
        string Name { get; set; }
        void Initialize();
        void Attack();
    }
}
