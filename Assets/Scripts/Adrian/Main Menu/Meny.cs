using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Meny : MonoBehaviour
{
    
    // Startar spelet, g�r in i "Game" scene.
    public void StartGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    // St�nger spelet
    public void QuitGame()
    {
        Application.Quit();
    }

}
