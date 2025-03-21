using UnityEngine;
using VContainer;

namespace DesignPatterns.Builder
{
    public class GameManager : MonoBehaviour
    {
        [Inject]
        private ICharacterBuilder _characterBuilder;
        void Start()
        {
            var mainCharacter = new CharacterBuilder()
                .SetHealth(1000)
                .SetName("Dragan Stamenkovic")
                .Build();
            mainCharacter.Print();

            var enemyCharacter = new CharacterBuilder()
                .SetHealth(250)
                .SetName("Troll")
                .Build();
            enemyCharacter.Print();
        }
    }
}
