using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    

    
     // Restart is called on click
   public void Restart()
    {
        LookAtScript.speed = 5;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
