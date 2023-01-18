using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boat : MonoBehaviour
{
    int score = 0;
    [SerializeField]
    TextMeshProUGUI scoreText;
    Vector3 dolphin;
    [SerializeField]
    float speed;
    [SerializeField]
    Transform b�t;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score + " points";
        dolphin = GameObject.FindGameObjectWithTag("Player").transform.position;
        dir = (dolphin - b�t.transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            print("du e b�g");
             Destroy(gameObject);
        }
    }
}
