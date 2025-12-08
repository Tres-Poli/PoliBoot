namespace Poli.Boot
{
    using System;
    using System.Collections.Generic;
    using VContainer;
    using VContainer.Unity;

    [Serializable]
    public class CompositeLoader : ILoader
    {
        public List<ScriptableLoader> loaders = new();

        public void Load(IContainerBuilder builder, LifetimeScope scope)
        {
            foreach (var loader in loaders)
            {
                loader.Load(builder, scope);
            }
        }
    }
}