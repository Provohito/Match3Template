using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Template.Base;
using Template.Core;

namespace Template
{
    public class MenuScreen : BaseScreen
    {
        public const string Exit_Settings = "Exit_Settings";
        public const string Exit_Game = "Exit_Game";


        [SerializeField]
        TextMeshProUGUI scoresText;

        public override void Show()
        {
            base.Show();

            scoresText.text = GameInfo.Instance.Scores.ToString();
        }

        public void OnSettingPressed()
        {
            Exit(Exit_Settings);
        }


        public void OnGamePressed()
        {
            Exit(Exit_Game);
        }
        
    }
}
