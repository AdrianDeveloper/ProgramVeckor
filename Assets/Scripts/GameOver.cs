using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Button restartButton;
    void Start()
    {
        Button btn = restartButton.GetComponent<Button>();
        btn.onClick.AddListener(Restart);
    }

    // Restart is called on click
    void Restart()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
