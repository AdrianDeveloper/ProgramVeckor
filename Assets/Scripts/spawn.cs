using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField]
    Transform spawner;

    [SerializeField]
    GameObject boat;
    float time = 0;
    [SerializeField]
    Transform delfin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(delfin.transform.position, Vector3.forward, 5);var      //roterar ett object runt delfinen precis utanf�r sk�rmen som spawnar in bomber eller b�tar - Emil
        time += 1 * Time.deltaTime;
        if (time >= 15)
        {
            Instantiate(boat, spawner.position, Quaternion.identity);
            time = 0;
        }
    }
}
