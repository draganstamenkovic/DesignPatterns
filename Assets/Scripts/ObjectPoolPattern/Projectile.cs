using UnityEngine;
using VContainer;

namespace DesignPatterns.ObjectPool
{
    public class Projectile : MonoBehaviour
    {
        [Inject]
        private IProjectilePool _projectilePool;
        void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.name.Equals("Boundary"))
            {
                _projectilePool.Pool.Release(gameObject);
            }
        }

        public void Destroy()
        {
            Destroy(gameObject);
        }

    }
}