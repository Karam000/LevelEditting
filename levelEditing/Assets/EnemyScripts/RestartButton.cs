using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
   public void OnRestart()
    {
        Application.LoadLevel(Application.loadedLevel);

    }
}
