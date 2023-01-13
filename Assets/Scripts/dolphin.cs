using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dolphin : MonoBehaviour
{
    private Renderer rend;
    [SerializeField]
    private Color colorToTurnTo = Color.white;
 

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rend.material.color = colorToTurnTo;
        }
    }
}
