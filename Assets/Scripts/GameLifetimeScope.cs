using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterComponentInHierarchy<IPlayerController>();
        builder.Register<InputHandler>(Lifetime.Singleton);
        builder.RegisterEntryPoint<InputHandler>();
    }
}
