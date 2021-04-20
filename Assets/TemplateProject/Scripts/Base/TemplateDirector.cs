using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Template.Core;

namespace Template.Base
{
    public class TemplateDirector : AppDirector
    {
        protected override void Awake()
        {
            base.Awake();

            SceneManager.LoadScene("Menu");
        }
    }
}
