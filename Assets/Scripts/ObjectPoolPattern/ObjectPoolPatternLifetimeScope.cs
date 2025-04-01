using DesignPatterns.Command;
using VContainer;
using VContainer.Unity;

public class ObjectPoolPatternLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        
        builder.RegisterComponentInHierarchy<IPlayerController>();
        builder.Register<ICommandController, CommandController>(Lifetime.Singleton);
        builder.Register<InputHandler>(Lifetime.Singleton);
        
        builder.RegisterEntryPoint<InputHandler>();
        
        
    }
}
