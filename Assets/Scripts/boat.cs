using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boat : MonoBehaviour
{
    [SerializeField]
    GameObject BOMB;

    Transform dp;
    Vector3 dolphin;
    [SerializeField]
    float speed;
    [SerializeField]
    Transform båt;
    Vector3 dir;
    
    // Start is called before the first frame update
    void Start()
    {
        dp = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
       // dir = (dolphin - båt.transform.position).normalized;
      //  transform.position += dir * speed * Time.deltaTime;
        transform.LookAt(dp.position);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bomb" )
        {
            pointcounter.score += 1;
            Destroy(this.gameObject);
        }
    }
}
