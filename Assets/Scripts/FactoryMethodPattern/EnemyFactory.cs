using UnityEngine;
using VContainer;

namespace DesignPatterns.FactoryMethod
{
    public class EnemyFactory : IEnemyFactory
    {
        [Inject] private EnemyPrefabs _enemyPrefabs;
        public IEnemy Create(int enemyType)
        {
            var x = Random.Range(-5, 5);
            var z = Random.Range(-5, 5);
            var spawnPosition = new Vector3(x, 0f, z);
            switch (enemyType)
            {
                // Goblin
                case 0:
                    var goblin = Object.Instantiate(_enemyPrefabs.goblinPrefab, spawnPosition, Quaternion.identity);
                    return goblin.GetComponent<Goblin>();
                // Hulk
                case 1:
                    var hulk = Object.Instantiate(_enemyPrefabs.hulkPrefab, spawnPosition, Quaternion.identity);
                    return hulk.GetComponent<Hulk>();
                // Vampire
                case 2:
                    var vampire = Object.Instantiate(_enemyPrefabs.vampirePrefab, spawnPosition, Quaternion.identity);
                    return vampire.GetComponent<Vampire>();
            }

            return null;
        }
    }
}