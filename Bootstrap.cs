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
                loader.Load(builder, this);
            }
        }
    }
}