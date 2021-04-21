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

