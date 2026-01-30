using StatePattern;
using VContainer;
using VContainer.Unity;

public class StateLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterComponentInHierarchy<PlayerStateController>();
        builder.RegisterComponentInHierarchy<IInputManager>();
    }
}
