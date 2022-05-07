using Assets.Scripts.Magic;
using UnityEngine;

namespace Assets.Scripts.Other
{
    public class InitManager:MonoBehaviour
    {
        [SerializeField] private BGMManager _bgmManager;
        [SerializeField] private SEManager _seManager;
        [SerializeField] private EffectManager _effectManager;

        void Start()
        {
            BaseMagic.InitManager(_bgmManager,_seManager,_effectManager);
        }
    }
}