using UnityEngine;

namespace Assets.Scripts.Other
{
    public class BGMManager:MonoBehaviour
    {
        [SerializeField] private AudioSource _source;

        [SerializeField] private AudioClip _bgmClip;
        
        public void Play()
        {
            _source.Play();
        }

        public void Stop()
        {
            _source.Stop();
        }

        public float GetcurrentBGMTime()
        {
            return _source.time;
        }
    }
}