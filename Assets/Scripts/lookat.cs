using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour
{
    Vector3 dir;
    [SerializeField]
    float speed;
    [SerializeField]
    Transform dolphinPos;
    [SerializeField]
    Transform LookAt;
    [SerializeField]
    KeyCode a;
    [SerializeField]
    KeyCode d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(dolphinPos.transform.position, Vector3.forward, 60 * Time.deltaTime);
        }
        dir = (LookAt.transform.position - dolphinPos.transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(dolphinPos.transform.position, Vector3.back, 60 * Time.deltaTime);
        }
    }
}