using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boat : MonoBehaviour
{
    int score;
    [SerializeField]
    GameObject BOMB;
    public Animator animator;
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
        

    }

    // Update is called once per frame
    void Update()
    {
        dp = GameObject.FindGameObjectWithTag("Player").transform;
        dolphin = GameObject.FindGameObjectWithTag("Player").transform.position;
        dir = (dolphin - båt.transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
        transform.LookAt(dp.position);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //death animation + deathtrigger V - adrian
        if (collision.gameObject.tag == "Bomb" )
        {
            animator.ResetTrigger("BoatExplosion");
            animator.SetTrigger("BoatExplosion");
            pointcounter.score += 1;
            StartCoroutine(Timer());
        }
    }
    //death timer v /David
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}

