using VContainer;
using VContainer.Unity;

namespace DesignPatterns.Builder
{
    public class BuilderLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<ICharacterBuilder, CharacterBuilder>(Lifetime.Singleton);
        }
    }
}
