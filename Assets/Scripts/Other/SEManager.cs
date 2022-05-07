using UnityEngine;

namespace Assets.Scripts.Other
{
    public class SEManager:MonoBehaviour
    {
        [SerializeField] private AudioSource _source;

        [SerializeField] private AudioClip[] _clips;
        
        public void Play(int index)
        {
            _source.PlayOneShot(_clips[index]);
            Debug.Log("PlaySE");
        }
    }
}