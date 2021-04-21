using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Match3
{
    public class LevelBtn : MonoBehaviour
    {
        [SerializeField]
        TextMeshProUGUI levelText;

        int levelIndex;
        public void SetIndex(int _levelIndex)
        {
            levelIndex = _levelIndex;
            levelText.text = (_levelIndex + 1).ToString();

        }

        public void OnBtnPressed()
        {
            LevelPressed.Invoke(levelIndex);
        }

        public Action<int> LevelPressed { get; set; } 
    }
}
