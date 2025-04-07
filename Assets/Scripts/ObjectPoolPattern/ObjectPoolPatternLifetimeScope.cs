using DesignPatterns.Command;
using DesignPatterns.ObjectPool;
using VContainer;
using VContainer.Unity;

public class ObjectPoolPatternLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        
        builder.RegisterComponentInHierarchy<IPlayerController>();
        builder.Register<ICommandController, CommandController>(Lifetime.Singleton);
        builder.Register<InputHandler>(Lifetime.Singleton);
        
        builder.Register<IProjectilePool, ProjectilePool>(Lifetime.Singleton);
        builder.RegisterComponentInHierarchy<ProjectileSpawner>();
        builder.RegisterEntryPoint<InputHandler>();
        
        
    }
}
