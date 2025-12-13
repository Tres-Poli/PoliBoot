namespace Poli.Boot
{
    using VContainer;
    using VContainer.Unity;

    public interface ILoader
    {
        public string Name { get; }
        public void Load(IContainerBuilder builder, LifetimeScope scope);
    }
}