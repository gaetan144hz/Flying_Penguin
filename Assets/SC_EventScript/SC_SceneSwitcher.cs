using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_SceneSwitcher : MonoBehaviour
{
    [SerializeField] private string scene;

    public void sceneSwitch()
    {
        SceneManager.LoadScene(scene);
    }
}
