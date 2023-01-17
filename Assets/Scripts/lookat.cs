using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class lookat : MonoBehaviour
{
     
    Vector3 dir;
    [SerializeField]
    TextMeshProUGUI dashtext;
    [SerializeField]
    private float speed = 5;
    [SerializeField]
    Transform dolphinPos;
    [SerializeField]
    Transform LookAt;
    [SerializeField]
    private KeyCode Left = KeyCode.A;
    [SerializeField]
    private KeyCode Right = KeyCode.D;
    float dashAmount = 3;

    TextMeshProUGUI dashAmountText;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
       dashtext.text = "Dashes remaining: " + dashAmount;
        if (Input.GetKey(Left))
        {
            transform.RotateAround(dolphinPos.transform.position, Vector3.forward, 100 * Time.deltaTime);
        }
        dir = (LookAt.transform.position - dolphinPos.transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
        if (Input.GetKey(Right))
        {
            transform.RotateAround(dolphinPos.transform.position, Vector3.back, 100 * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) && dashAmount > 0 )
        {
            StartCoroutine(dash());
        }


    }
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border") 
        {
            StartCoroutine(MyCoroutine());
           
        } 
    }

    IEnumerator MyCoroutine()
    {
        speed = -5;
        yield return new WaitForSeconds(1);
        speed = 5;
    }
    IEnumerator dash()
    {
        dashAmount -= 1; 
        speed = 10;
        yield return new WaitForSeconds(2);
        speed = 5;
    }
}

