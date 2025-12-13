namespace Poli.Boot
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;
    using VContainer;
    using VContainer.Unity;

    [Serializable]
    public class CompositeLoader : ILoader
    {
        [SerializeField]
        private string _name;
        
        public List<ScriptableLoader> loaders = new();
        public string Name => _name;

        public void Load(IContainerBuilder builder, LifetimeScope scope)
        {
            foreach (var loader in loaders)
            {
                Debug.Log($"    Loading: {loader.Name}...");
                loader.Load(builder, scope);
                Debug.Log($"    Loaded: {loader.Name}");
            }
        }
    }
}