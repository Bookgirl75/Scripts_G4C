using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public enum Scenes
    {
        homePage,
        creditsPage,
        selectPage,
        controlsPage,
        fam1PlantingScene,
        resultsScene,
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

    public void LoadSelect()
    {
        SceneManager.LoadScene(Scenes.selectPage.ToString());
    }

    public void LoadControls()
    {
        SceneManager.LoadScene(Scenes.controlsPage.ToString());
    }

    public void LoadFamilyOnePlanting()
    {
        SceneManager.LoadScene(Scenes.fam1PlantingScene.ToString());
    }

    public void LoadGameResults()
    {
        SceneManager.LoadScene(Scenes.resultsScene.ToString());
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            LoadHome();
        }
    }
}
