using System.Collections;
using System.Collections.Generic;
using Template.Base;
using Template.Core;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Template
{
    public class ResultsScreen : BaseScreen
    {
        public const string Exit_Menu = "Exit_Menu";
        public const string Exit_Replay = "Exit_Replay";

        [SerializeField]
        TextMeshProUGUI scoresText;
        public override void Show()
        {
            base.Show();

            scoresText.text = GameInfo.Instance.Scores.ToString();
        }

        public void OnRestartPressed()
        {
            Exit(Exit_Replay);
        }

        public void OnMenuPressed()
        {
            Exit(Exit_Menu);
        }
    }
}
