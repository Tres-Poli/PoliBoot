namespace Poli.Boot
{
    using UnityEngine;
    using VContainer;
    using VContainer.Unity;

    public abstract class ScriptableLoader : ScriptableObject, ILoader
    {
        public abstract void Load(IContainerBuilder builder, LifetimeScope scope);
    }
}