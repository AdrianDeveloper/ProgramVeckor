using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour
{
     
    Vector3 dir;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Left))
        {
            transform.RotateAround(dolphinPos.transform.position, Vector3.forward, 60 * Time.deltaTime);
        }
        dir = (LookAt.transform.position - dolphinPos.transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
        if (Input.GetKey(Right))
        {
            transform.RotateAround(dolphinPos.transform.position, Vector3.back, 60 * Time.deltaTime);
        }
     
        


    }
}
