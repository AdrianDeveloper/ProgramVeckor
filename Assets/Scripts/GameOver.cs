using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = restartButton.GetComponent<Button>();
    }
     // Restart is called on click
    void Restart()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
