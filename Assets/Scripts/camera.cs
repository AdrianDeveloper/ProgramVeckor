using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField]
    public float speed = 0.5f;
    [SerializeField]
    public float zvalue = -7f;
    [SerializeField]
    Transform dolphin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, dolphin.position + new Vector3(0,0,zvalue), speed);
    }
}
