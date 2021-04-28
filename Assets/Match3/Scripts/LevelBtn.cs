﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Match3
{
    public class LevelBtn : MonoBehaviour
    {
        [SerializeField]
        TextMeshProUGUI levelText;

        Button button;

        int levelIndex;

        private void Awake()
        {
            button = GetComponent<Button>();
        }
        public void Setup(int _levelIndex, LevelState _levelState)
        {
            levelIndex = _levelIndex;
            levelText.text = (_levelIndex + 1).ToString();

            button.interactable = _levelState == LevelState.Unlocked;

        }

        public void OnBtnPressed()
        {
            LevelPressed.Invoke(levelIndex);
        }

        public Action<int> LevelPressed { get; set; } 
    }
}
