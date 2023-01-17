using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dolphin : MonoBehaviour
{
    private Renderer rend;
    [SerializeField]
    private Color colorToTurnTo = Color.white;
    int onground = 1;

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
            onground = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (onground == 1)
        {
            if (collision.gameObject.tag == "enemy")
            {
                Destroy(this.gameObject);
            }
        }
      if (collision.gameObject.tag == "border")
        {
            Destroy(this.gameObject);
        } 
       
    }
}

