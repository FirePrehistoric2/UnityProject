using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonControls : MonoBehaviour
{
   
    public void BackButton()

    {

        SceneManager.LoadScene("MainMenu");

    }

}