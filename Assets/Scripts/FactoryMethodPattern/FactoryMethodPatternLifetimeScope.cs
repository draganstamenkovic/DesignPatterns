using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace DesignPatterns.FactoryMethod
{
    public class FactoryMethodPatternLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            var enemyPrefabs = Resources.Load<EnemyPrefabs>("EnemyPrefabs");
            builder.RegisterInstance(enemyPrefabs);

            builder.Register<IEnemyFactory, EnemyFactory>(Lifetime.Singleton);
            builder.RegisterComponentInHierarchy<EnemySpawner>();

        }
    }
}