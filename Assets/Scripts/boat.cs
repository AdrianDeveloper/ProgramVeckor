using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : MonoBehaviour
{
    Vector3 dolphin;
    [SerializeField]
    float speed;
    [SerializeField]
    Transform b�t;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
                Destroy(this.gameObject);
            }
        }
    }
}
