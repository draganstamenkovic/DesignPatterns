using UnityEngine;

namespace PrototypePattern
{
    public class BaseEnemy : MonoBehaviour, IPrototype
    {
        [SerializeField] protected Renderer _renderer;
        public Color MaterialColor { get; set; }
        public float Size { get; set; }
        public string Name { get; set; }
        
        public void Initialize()
        {
            Name = name;
            _renderer.material.color = MaterialColor;
            ApplyHeightAndScale();
        }

        private void ApplyHeightAndScale()
        {
            var position = transform.position;
            position.y = Size - Size / 2;
            transform.position = position;
            
            transform.localScale = new Vector3(Size, Size, Size);
        }

        public IPrototype Clone()
        {
            var x = Random.Range(-10, 10);
            var z = Random.Range(-10, 10);
            
            return Instantiate(this, new Vector3(x,0,z), Quaternion.identity);
        }

        public void Print()
        {
            Debug.Log("Name: " + Name + " | Color: " + MaterialColor + " | Size: " + Size);
        }
    }
}
