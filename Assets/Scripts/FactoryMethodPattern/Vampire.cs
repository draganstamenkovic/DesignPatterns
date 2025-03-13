using UnityEngine;

namespace DesignPatterns.FactoryMethod
{
    public class Vampire : BaseEnemy
    {
        public override void Initialize()
        {
            Name = "Vampire";
        }

        public override void Attack()
        {
            Debug.Log("Delicies blood!");
        }
    }
}