using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Match3.Base;
using Match3.Core;

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

            scoresText.text = GameInfo.Instance.Scores.ToString();

            levelsGrid.ShowLevels();
        }


        public void OnGamePressed()
        {
            Exit(Exit_Game);
        }
        
    }
}
