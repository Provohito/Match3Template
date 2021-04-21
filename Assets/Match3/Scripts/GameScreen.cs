using System.Collections;
using System.Collections.Generic;
using Match3.Base;
using Match3.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Match3
{
    public class GameScreen : BaseScreen
    {
        public const string Exit_Result = "Exit_Result";

        public override void Show()
        {
            base.Show();

            GameInfo.Instance.Scores = 10;
        }

        public void OnEndGamePressed()
        {
            Exit(Exit_Result);
        }
    }
}
