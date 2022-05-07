using System;
using System.Collections.Generic;
using Assets.Scripts.Magic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Player
{
    public class PlayerCommandInput:MonoBehaviour
    {
        [SerializeField]
        private Text _text;
        private String _currentString;
        
        
        void Update()
        {
            if (!Input.anyKeyDown) return;
            
            if (Input.GetKeyDown(KeyCode.Return))
            {
                BaseMagic magic = FindMagic(_currentString);
                magic?.PlayMagic();


                _currentString = "";
                _text.text = _currentString;
                
                return;
            }
            string keyStr = Input.inputString;
            _currentString += keyStr;
            _text.text = _currentString;
            Debug.Log(keyStr);
        }


        BaseMagic FindMagic(String str)
        {
            
            _dictionary.TryGetValue( str, out var resultMagic );

            return resultMagic;
        }
        
        Dictionary<String,BaseMagic> _dictionary = new Dictionary<string, BaseMagic>()
        {
            {"fire",new FireMagic()},
            {"stopbgm",new StopBGMMagic()},
            {"startbgm",new StartBGMMagic()}
        };
    }
}