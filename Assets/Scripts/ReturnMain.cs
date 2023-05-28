using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMain : MonoBehaviour
{
    private string previousSceneName;

    public void LoadRoomScene()
    {
        previousSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Room");
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(previousSceneName);
    }
}
