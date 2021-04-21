using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Match3
{
    public class LevelsGrid : MonoBehaviour
    {
        [SerializeField]
        GameObject levelBtnPrefab;

        public void ShowLevels()
        {
            for(int i = 0; i < 10; i++)
            {
                var _levelBtn = Instantiate(levelBtnPrefab, transform).GetComponent<LevelBtn>();
                _levelBtn.SetIndex(i);
                _levelBtn.LevelPressed += OnLevelSelected;
            }
        }

        void OnLevelSelected(int _levelIndex)
        {
            Debug.Log("OnLevelSelected: "+ _levelIndex);
        }
    }
}
