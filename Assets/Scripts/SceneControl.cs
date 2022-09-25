using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void ExteriorScene()
    {
        SceneManager.LoadScene(2);
    }

    public void InteriorScene()
    {
        SceneManager.LoadScene(1);
    }

    public void StartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitScene()
    {
        Application.Quit();
    }
}
