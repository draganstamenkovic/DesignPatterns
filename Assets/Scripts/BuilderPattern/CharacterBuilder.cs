namespace DesignPatterns.Builder
{
    public class CharacterBuilder : ICharacterBuilder
    {
        private Character _character = new();

        public CharacterBuilder()
        {
            Reset();
        }

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetHealth(float health)
        {
            _character.Health = health;
            return this;
        }

        private void Reset()
        {
            _character = new Character()
            {
                Name = "Unnamed",
                Health = 100f
            };
        }

        public Character Build()
        {
            Character result = _character;
            Reset();
            return result;
        }
    }
}