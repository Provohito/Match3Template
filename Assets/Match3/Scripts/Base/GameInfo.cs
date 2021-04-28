using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Match3.Core;
using System;

namespace Match3.Base
{
    public class GameInfo : BaseManager<GameInfo>
    {
        [SerializeField]
        List<LevelConfig> levelsConfigs;

        public List<LevelConfig> LevelsConfigs => levelsConfigs;

        public void RegisterResult(int _stepsRemaining, int _matchsRemaining)
        {
            LevelResultInfo = new LevelResultInfo();

            if (_matchsRemaining == 0)
                LevelResultInfo.Scores = GlobalConfig.SCORES_FOR_STEP * _stepsRemaining;

            Scores += LevelResultInfo.Scores;

            PlayerPrefs.Save();
        }

        public int Scores
        {
            get => PlayerPrefs.GetInt(PrefsKeys.Scores);

            set => PlayerPrefs.SetInt(PrefsKeys.Scores, value);
        }

        public int LevelIndex { get; set; }
        public LevelConfig LevelConfig => LevelsConfigs[LevelIndex];

        public LevelResultInfo LevelResultInfo { get; private set; }
    }

    public class LevelResultInfo
    {
        public int Scores { get; set; }
    }

    [Serializable]
    public class LevelConfig
    {
        [SerializeField]
        int stepsCount;
        [SerializeField]
        int matchCount;


        public int StepsCount => stepsCount;
        public int MatchCount => matchCount;

    }
}

