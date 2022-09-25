using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void ExteriorScene()
    {
        SceneManager.LoadScene(1);
    }

    public void InteriorScene()
    {
        SceneManager.LoadScene(0);
    }
}
