using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class BackToMenuLvSelect : MonoBehaviour
{
   
    public void BackButton()

    {

        SceneManager.LoadScene("MainMenu");

    }

}