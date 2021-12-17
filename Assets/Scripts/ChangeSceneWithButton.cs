using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWithButton : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public string urlstring = "https://xyzdev.herokuapp.com/vista/vista_grafica";
    public void LoadURL()
    {
        Application.OpenURL(urlstring);
    }
}
