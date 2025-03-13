using UnityEngine;

namespace DesignPatterns.FactoryMethod
{
    public class BaseEnemy : MonoBehaviour, IEnemy
    {
        public string Name { get; set; }
        public virtual void Initialize()
        {
            Name = "Base Enemy";
        }

        public virtual void Attack()
        {
            Debug.Log($"You got smacked by {Name}");
        }
    }
}