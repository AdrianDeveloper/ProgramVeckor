using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    [SerializeField]
    Transform dolphin;


    private int spawn = 0;  
    // Start is called before the first frame update
    void Start()
    {
        spawn = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn == 1)
        {
            transform.position = dolphin.position + new Vector3( Random.Range(12,-12),Random.Range(10,-10),0);
            spawn = 0;
        } 
    }
}
