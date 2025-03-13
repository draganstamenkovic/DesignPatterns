using UnityEngine;

namespace DesignPatterns.FactoryMethod
{
    public class Goblin : BaseEnemy
    {
        public override void Initialize()
        {
            Name = "Goblin";
        }

        public override void Attack()
        {
            Debug.Log("Goblin Attacked");
        }
    }
}