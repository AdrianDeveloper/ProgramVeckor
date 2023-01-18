using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointcounter : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText;
    public static int score;
   
    // Start is called before the first frame update
    void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    { //functional counter v
        scoreText.text = score + " points";
      
    }
    
}
