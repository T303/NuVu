using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void ExteriorScene(string exteriorScene)
    {
        SceneManager.LoadScene(exteriorScene);
    }

    public void InteriorScene(string interiorScene)
    {
        SceneManager.LoadScene(interiorScene);
    }
}
