using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public enum Scenes
    {
        homePage,
        creditsPage,
        scenePage,
        controlsPage,
        plantingScene,
        resultsScene,
        artCreditScene,
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadHome()
    {
        SceneManager.LoadScene(Scenes.homePage.ToString());
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene(Scenes.creditsPage.ToString());
    }

    public void LoadSceneCut()
    {
        SceneManager.LoadScene(Scenes.scenePage.ToString());
    }

    public void LoadControls()
    {
        SceneManager.LoadScene(Scenes.controlsPage.ToString());
    }

    public void LoadPlanting()
    {
        SceneManager.LoadScene(Scenes.plantingScene.ToString());
    }

    public void LoadGameResults()
    {
        SceneManager.LoadScene(Scenes.resultsScene.ToString());
    }
    
    public void LoadArtCredits()
    {
        SceneManager.LoadScene(Scenes.artCreditScene.ToString());
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("game quit");
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            LoadHome();
        }
    }
}
