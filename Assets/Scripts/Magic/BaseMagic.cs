using Assets.Scripts.Other;

namespace Assets.Scripts.Magic
{
    public class BaseMagic
    {
        private static BGMManager _bgmManager;
        private static SEManager _SEManager;
        private static EffectManager _effectManager;
        

        public static void InitManager(BGMManager bgmManager,SEManager seManager,EffectManager effectManager)
        {
            _bgmManager = bgmManager;
            _SEManager = seManager;
            _effectManager = effectManager;
        }
        
        

        public void PlayMagic()
        {
            activate();
        }
        
        protected virtual void activate()
        {
            
        }

        protected void PlaySE(int index)
        {
            _SEManager.Play(index);
        }

        protected void PlayVFX(int index)
        {
            _effectManager.Play(index);
        }

        protected BGMManager GetBGMManager()
        {
            return _bgmManager;
        }
    }
}