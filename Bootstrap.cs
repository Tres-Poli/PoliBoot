namespace Poli.Boot
{
    using UnityEngine;
    using VContainer;
    using VContainer.Unity;

    public class Bootstrap : LifetimeScope
    {
        [SerializeField] 
        public BootConfig bootConfig;
        
        protected override void Configure(IContainerBuilder builder)
        {   
            foreach (var loader in bootConfig.GetLoaders())
            {
                Debug.Log($"Loading: {loader.Name}");
                loader.Load(builder, this);
                Debug.Log($"Loaded: {loader.Name}");
            }
        }
    }
}