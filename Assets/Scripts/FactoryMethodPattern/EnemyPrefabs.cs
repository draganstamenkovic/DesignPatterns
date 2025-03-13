using UnityEngine;

namespace DesignPatterns.FactoryMethod
{
    [CreateAssetMenu(fileName = "EnemyPrefabs", menuName = "ScriptableObjects/EnemyPrefabs")]
    public class EnemyPrefabs : ScriptableObject
    {
        public GameObject goblinPrefab;
        public GameObject hulkPrefab;
        public GameObject vampirePrefab;
    }
}