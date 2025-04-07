using UnityEngine;
using UnityEngine.Pool;

namespace DesignPatterns.ObjectPool
{
    public interface IProjectilePool
    {
        IObjectPool<GameObject> Pool { get; }
        void Initialize(GameObject pooledObject, Transform poolParent, int defaultCapacity, int maxCapacity);
        
    }
}