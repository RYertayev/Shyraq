using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject MenuPage;
    [SerializeField] private GameObject settingsPage; 
    [SerializeField] private GameObject models; 
    void Start()
    {
        settingsPage.SetActive(false);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void PlayGamePuzzle()
    {
        SceneManager.LoadScene(1);
    }
    public void Settings()
    {
        MenuPage.SetActive(false);
        settingsPage.SetActive(true);
        models.SetActive(false);
    }
    public void Back()
    {
        settingsPage.SetActive(false);
        models.SetActive(true);
    }
    public void SecondLevelPuzzle()
    {
        SceneManager.LoadScene(2);
    }
    public void ThirdLevelPuzzle()
    {
        SceneManager.LoadScene(3);
    }
    public void Menu()
    {
        MenuPage.SetActive(true);
        settingsPage.SetActive(false);
        models.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
