using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Match3.Base;
using Match3.Core;
using System;

namespace Match3
{
    public class MenuScreen : BaseScreen
    {
        public const string Exit_Game = "Exit_Game";


        [SerializeField]
        TextMeshProUGUI scoresText;
        [SerializeField]
        LevelsGrid levelsGrid;

        public override void Show()
        {
            base.Show();

            scoresText.text = "Scores: " + GameInfo.Instance.Scores.ToString();

            levelsGrid.LevelSelected += OnLevelSelected;

            levelsGrid.ShowLevels(GameInfo.Instance.LevelsConfigs);
        }

        private void OnLevelSelected(int _levelIndex)
        {
            GameInfo.Instance.LevelIndex = _levelIndex;
            Exit(Exit_Game);
        }
    }
}
