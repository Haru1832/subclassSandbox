using UnityEngine;

namespace Assets.Scripts.Other
{
    public class EffectManager:MonoBehaviour
    {
        [SerializeField]
        private GameObject[] effectPrefabs;
        
        public void Play(int index)
        {
            Instantiate(effectPrefabs[index]);
        }
    }
}