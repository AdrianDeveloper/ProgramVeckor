using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boat : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    Transform del;
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
        dir = (del.transform.position - båt.transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
    }
}
