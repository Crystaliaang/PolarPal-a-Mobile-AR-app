using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    bool dive;

    public void PlayGame ()
    {
        SceneManager.LoadScene("MainApp");
    }

    public void Instructions ()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Simulation()
    {
        SceneManager.LoadScene("Simulation");
    }


    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit!"); 
        Application.Quit();
    }

    public void Dive()
    {
        dive = true;
    }
}
