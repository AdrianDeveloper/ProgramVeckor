using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointcounter : MonoBehaviour
{

    int score = 0;
    TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score + "-";
        if (Input.GetKeyDown(KeyCode.R))
        {
            score += 1;
        }
    }
}
