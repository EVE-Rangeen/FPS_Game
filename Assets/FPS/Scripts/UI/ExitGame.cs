using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void OnExitGame()
    {
        // if (Application.isEditor)
        // {
        //     UnityEditor.EditorApplication.isPlaying = false;
        //     return;
        // }
        // else
        Application.Quit();

    }
}
