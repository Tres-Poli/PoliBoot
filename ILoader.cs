namespace Poli.Boot
{
    using VContainer;
    using VContainer.Unity;

    public interface ILoader
    {
        public void Load(IContainerBuilder builder, LifetimeScope scope);
    }
}