using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class scoretext : MonoBehaviour
{
    TextMeshProUGUI textMesh;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = "score: " + score.ToString();
        if (Input.GetKeyDown(KeyCode.R))
        {
            score++;
        }
    }
}
