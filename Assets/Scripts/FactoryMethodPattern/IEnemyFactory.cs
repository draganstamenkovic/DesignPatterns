namespace DesignPatterns.FactoryMethod
{
    public interface IEnemyFactory
    {
        IEnemy Create(int enemyType);
    }
}