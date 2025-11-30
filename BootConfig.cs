namespace Poli.Boot
{
    using UnityEngine;

    [CreateAssetMenu(menuName = "Poli/Configs/Boot", fileName = "BootConfig")]
    public abstract class BootConfig : ScriptableObject
    {
        public abstract ILoader[] GetLoaders();
    }
}