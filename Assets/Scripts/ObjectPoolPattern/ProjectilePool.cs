using UnityEngine;
using UnityEngine.Pool;
using VContainer;
using VContainer.Unity;

namespace DesignPatterns.ObjectPool
{
    public class ProjectilePool : IProjectilePool
    {
        private GameObject _pooledObject;
        private Transform _poolParent;
        private int _defaultCapacity = 5;
        private int _maxCapacity = 10;
        private bool _collectionChecks = true;
        
        private IObjectPool<GameObject> _pool;
        
        private IObjectResolver _objectResolver;
        public IObjectPool<GameObject> Pool
        {
            get
            {
                if (_pool == null)
                {
                    _pool = new ObjectPool<GameObject>
                    (
                        CreatePooledObject,
                        TakeFromPool,
                        ReturnToPool,
                        DestroyPooledObject,
                        _collectionChecks,
                        _defaultCapacity,
                        _maxCapacity
                    );
                }

                return _pool;
            }
        }
        [Inject]
        public void Construct(IObjectResolver objectResolver)
        {
            _objectResolver = objectResolver;
        }

        public void Initialize(GameObject pooledObject, Transform poolParent, int defaultCapacity, int maxCapacity)
        {
            _pooledObject = pooledObject;
            _poolParent = poolParent;
            _defaultCapacity = defaultCapacity;
            _maxCapacity = maxCapacity;
        }

        private GameObject CreatePooledObject()
        {
            var bullet = _objectResolver.Instantiate(_pooledObject, _poolParent, true);
            bullet.gameObject.SetActive(false);
            return bullet;
        }
        private void TakeFromPool(GameObject bullet)
        {
            bullet.gameObject.SetActive(true);
        }
        private void ReturnToPool(GameObject bullet)
        {
            bullet.gameObject.SetActive(false);
        }
        private void DestroyPooledObject(GameObject bullet)
        {
            var projectile = bullet.GetComponent<Projectile>();
            projectile.Destroy();
        }
    }
}