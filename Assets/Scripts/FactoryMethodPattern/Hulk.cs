using UnityEngine;

namespace DesignPatterns.FactoryMethod
{
    public class Hulk : BaseEnemy
    {
        public override void Initialize()
        {
            Name = "Hulk";
        }

        public override void Attack()
        {
            Debug.Log("HULK SMASH!");
        }
    }
}