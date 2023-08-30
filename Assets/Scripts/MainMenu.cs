using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void PlayGame()

    {

        SceneManager.LoadScene("Level Select");

    }

    public void QuitGame ()

    {

        Debug.Log("QUIT!");
        Application.Quit();

    }

    public void Options()

    {

       SceneManager.LoadScene("Options");

    }

     public void KnownBugs()

    {

       SceneManager.LoadScene("KnownBugs");

    }

}
