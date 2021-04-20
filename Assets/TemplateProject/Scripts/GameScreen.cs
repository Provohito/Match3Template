using System.Collections;
using System.Collections.Generic;
using Template.Base;
using Template.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Template
{
    public class GameScreen : BaseScreen
    {
        public const string Exit_Settings = "Exit_Settings";
        public const string Exit_Result = "Exit_Result";

        public override void Show()
        {
            base.Show();

            GameInfo.Instance.Scores = 10;
        }

        public void OnSettingPressed()
        {
            Exit(Exit_Settings);
        }

        public void OnEndGamePressed()
        {
            Exit(Exit_Result);
        }
    }
}
