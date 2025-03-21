using UnityEngine;

namespace DesignPatterns.Builder
{
    public class Character
    {
        public string Name { get; set; }
        public float Health { get; set; }

        public void Print()
        {
            Debug.Log($"Name: {Name} | Health: {Health}");
        }
    }
}