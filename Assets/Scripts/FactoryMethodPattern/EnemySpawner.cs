using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace DesignPatterns.FactoryMethod
{
    public class EnemySpawner : MonoBehaviour
    {
        [Inject] private IEnemyFactory _enemyFactory;
        
        [SerializeField] private TMP_Dropdown _enemyTypeDropdown;
        [SerializeField] private Button _spawnButton;

        private void OnEnable()
        {
            _spawnButton.onClick.AddListener(OnSpawnButtonClicked);
        }

        private void OnDisable()
        {
            _spawnButton.onClick.RemoveListener(OnSpawnButtonClicked);
        }

        private void OnSpawnButtonClicked()
        {
            if(_enemyFactory == null)
                Debug.LogError("Enemy spawner is null");
            var enemy = _enemyFactory.Create(_enemyTypeDropdown.value);
            enemy.Initialize();
            enemy.Attack();
        }
    }
}