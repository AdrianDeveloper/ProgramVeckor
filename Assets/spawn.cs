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
        time += Time.deltaTime;
        if (time <= 15)
        {
            Instantiate(boat, spawner.position, Quaternion.identity);
            time = 0;
        }
    }
}
