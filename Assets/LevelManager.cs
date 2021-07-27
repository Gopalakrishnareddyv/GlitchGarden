using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public float autoLoadLevelTimer;
    private void Start()
    {
        Invoke("LoadNextLevel", autoLoadLevelTimer);
    }
    [System.Obsolete]
    public void LoadLevel(string anme)
    {
        Application.LoadLevel(name);
    }
    public void Quit()
    {
        Application.Quit();
    }
    
    [System.Obsolete]

    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(2);
    }
}
