using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class KnownBugs : MonoBehaviour
{

    public void BackToMenuBugs()

    {

        SceneManager.LoadScene("MainMenu");

    }

}
