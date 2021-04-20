using System;
using System.Collections;
using System.Collections.Generic;
using Template.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Template
{
    public class MenuDirector : SceneDirector
    {

        protected override void Start()
        {
            base.Start();

            SetCurrentScreen<MenuScreen>().Show();
        }
        protected override void OnScreenExit(Type _screenType, string _exitCode)
        {
            if(_screenType == typeof(MenuScreen))
            {
                if (_exitCode == MenuScreen.Exit_Game)
                    SceneManager.LoadScene(Scenesids.Game);
                else if (_exitCode == MenuScreen.Exit_Settings)
                    SetCurrentScreen<SettingsScreen>().Show();
            }
            else if(_screenType == typeof(SettingsScreen))
            {
                if (_exitCode == SettingsScreen.Exit_Back)
                    SetCurrentScreen<MenuScreen>().Show();
            }
        }
    }
}
