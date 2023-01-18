using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boat : MonoBehaviour
{
    [SerializeField]
    GameObject BOMB;
    int score = 0;
    [SerializeField]
    TextMeshProUGUI scoreText;
    Vector3 dolphin;
    [SerializeField]
    float speed;
    [SerializeField]
    Transform båt;
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
        dir = (dolphin - båt.transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bomb" )
        {   
            score += 1;
            Destroy(this.gameObject);
        }
    }
}
