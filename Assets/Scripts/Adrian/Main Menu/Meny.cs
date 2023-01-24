using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Meny : MonoBehaviour
{
    
    // Startar spelet, går in i "Game" scene.
    public void StartGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    // Stänger spelet
    public void QuitGame()
    {
        Application.Quit();
    }

}
