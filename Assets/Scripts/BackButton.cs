using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class BackButton : MonoBehaviour
{
   
    public void BackToMenu()

    {

        SceneManager.LoadScene("Menu");

    }

}