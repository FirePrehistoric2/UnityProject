using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    
   public void LevelOne()

    {

        SceneManager.LoadScene("Level1");

    }

    public void LevelTwo()

    {

        SceneManager.LoadScene("Level2");
        
    }

}
