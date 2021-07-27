using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelController : MonoBehaviour
{
    public GameObject main;
    public GameObject settings;

    public void Main()
    {
        main.SetActive(true);
        settings.SetActive(false);
    }
    public void Settings()
    {
        main.SetActive(false);
        settings.SetActive(true);
    }
    
}
