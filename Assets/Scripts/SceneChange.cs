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
        var sceneLoading = SceneManager.LoadSceneAsync("Event"); // permet de charger la sc�ne en d�caler
        sceneLoading.allowSceneActivation = false; // bloque l'affichage de la sc�ne suivante.
        while (sceneLoading.isDone == false)
        {
            if (sceneLoading.progress >= 0.9f) //chargement dans unity est � 90% le rest c'est l'affichage sur le screen
            {
                sceneLoading.allowSceneActivation = true; //r�autorise l'affichage de la sc�ne game.
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
        SceneManager.LoadScene("UI_Menu");
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