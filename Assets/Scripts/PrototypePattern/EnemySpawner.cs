using PrototypePattern;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private BaseEnemy _enemy;
    [SerializeField] private TMP_Dropdown _enemyTypeDropdown;
    [SerializeField] private TMP_Dropdown _colorDropdown;
    [SerializeField] private Button _cloneButton;

    private void OnEnable()
    {
        _cloneButton.onClick.AddListener(OnCloneButtonClicked);
    }

    private void OnDisable()
    {
        _cloneButton.onClick.RemoveListener(OnCloneButtonClicked);
    }

    private void OnCloneButtonClicked()
    {
        BaseEnemy enemyClone = null;
        if (_enemyTypeDropdown.value == (int)EnemyType.Troll)
        {
            enemyClone = (BaseEnemy)_enemy.Clone();
            enemyClone.MaterialColor = GetSelectedColor();
            enemyClone.Name = "Troll";
            enemyClone.Size = 2f;
            enemyClone.Initialize();
            enemyClone.Print();
        }

        if (_enemyTypeDropdown.value == (int)EnemyType.Vampire)
        {
            enemyClone = (BaseEnemy)_enemy.Clone();
            enemyClone.MaterialColor = GetSelectedColor();
            enemyClone.Name = "Vampire";
            enemyClone.Size = 0.5f;
            enemyClone.Initialize();
            enemyClone.Print();
        }
    }

    private Color GetSelectedColor()
    {
        if (_colorDropdown.value == (int)ColorEnum.Red)
            return Color.red;
        
        return Color.blue;
    }
}

public enum EnemyType
{
    Troll,
    Vampire
}

public enum ColorEnum
{
    Red,
    Blue
}
