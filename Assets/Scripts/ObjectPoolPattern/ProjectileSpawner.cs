using UnityEngine;
using VContainer;

namespace DesignPatterns.ObjectPool
{
    public class ProjectileSpawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject _projectile;
        [SerializeField]
        private Transform _spawnPoint;
        [SerializeField]
        private int _defaultCapacity = 5;
        [SerializeField] 
        private int _maxPoolSize = 10;
        [SerializeField]
        private float _bulletSpeed = 10f;
        [Inject]
        private IProjectilePool _projectilePool;
        void Start()
        {
            _projectilePool.Initialize(
                _projectile,
                _spawnPoint,
                _defaultCapacity,
                _maxPoolSize
                );
        }

        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
                CreateProjectile();
        }

        void CreateProjectile()
        {
            var newBullet = _projectilePool.Pool.Get();

            newBullet.transform.position = _spawnPoint.position;
            var bulletRB = newBullet.GetComponent<Rigidbody>();
            bulletRB.linearVelocity = transform.forward * _bulletSpeed; 
        }
    }
}
