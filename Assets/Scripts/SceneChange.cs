using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    [SerializeField] GameObject loadingScreenPrefab;
    
    public void LoadSceneAsync()
    {
        StartCoroutine(LoadingScreenCoroutine());
    }

    private IEnumerator LoadingScreenCoroutine()
    {
        var prefab = Instantiate(loadingScreenPrefab);
        DontDestroyOnLoad(prefab);
        var sceneLoading = SceneManager.LoadSceneAsync("GameScene"); // permet de charger la scène en décaler
        sceneLoading.allowSceneActivation = false; // bloque l'affichage de la scène suivante.
        while (sceneLoading.isDone == false)
        {
            if (sceneLoading.progress >= 0.9f) //chargement dans unity est à 90% le rest c'est l'affichage sur le screen
            {
                sceneLoading.allowSceneActivation = true; //réautorise l'affichage de la scène game.
                prefab.SetActive(false);
            }
            yield return new WaitForSeconds(1);
        }
        //yield return new WaitForSeconds(2);
        //SceneManager.LoadScene("Game");
        //yield return null;
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ToCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    
    public void ToControls()
    {
        SceneManager.LoadScene("Controls");
    }
       
    public void ToQuit()
    {
        Application.Quit();
    }

}