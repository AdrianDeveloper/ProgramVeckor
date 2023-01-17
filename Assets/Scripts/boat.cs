using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boat : MonoBehaviour
{
    int score = 0;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                score += 1;
                Destroy(this.gameObject);
            }
        }
    }
}
