using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenItchPage : MonoBehaviour
{
    public string scene;

    public void OpenItchPageFunc()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(scene);
    }
}
