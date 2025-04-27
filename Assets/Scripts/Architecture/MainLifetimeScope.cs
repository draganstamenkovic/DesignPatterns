using VContainer;
using VContainer.Unity;

namespace DesignPatterns.Architecture
{
    public class MainLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            // We just pass IContainerBuilder to other parts of the managers for example
            // 1. Analytics (builder)
            // 2. GUI (builder)
            
            AnalyticsScope.Register(builder);
        }
    }
}