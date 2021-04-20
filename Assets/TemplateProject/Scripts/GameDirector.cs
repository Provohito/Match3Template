using System;
using System.Collections;
using System.Collections.Generic;
using Template.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Template
{
    public class GameDirector : SceneDirector
    {
        protected override void Start()
        {
            base.Start();

            SetCurrentScreen<GameScreen>().Show();
        }
        protected override void OnScreenExit(Type _screenType, string _exitCode)
        {
            if(_screenType == typeof(GameScreen))
            {
                if (_exitCode == GameScreen.Exit_Settings)
                    SetCurrentScreen<SettingsScreen>().Show();
                else if (_exitCode == GameScreen.Exit_Result)
                    SetCurrentScreen<ResultsScreen>().Show();
            }
            else if (_screenType == typeof(SettingsScreen))
            {
                if (_exitCode == SettingsScreen.Exit_Back)
                    SetCurrentScreen<GameScreen>().Show();
            }
            else if (_screenType == typeof(ResultsScreen))
            {
                if (_exitCode == ResultsScreen.Exit_Menu)
                    SceneManager.LoadScene(Scenesids.Menu);
                else if (_exitCode == ResultsScreen.Exit_Replay)
                    SetCurrentScreen<GameScreen>().Show();
            }
        }
    }
}
