using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dolphin : MonoBehaviour
{

    private Animator gameAnimator;
    private Renderer rend;
    public bool onground = true;
    public bool hasBomb = false;
    [SerializeField]
    private Color colorToTurnTo = Color.white;
    private KeyCode dropBomb = KeyCode.Q;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        gameAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasBomb == true)
        {
            Debug.Log("HAS BOMB");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rend.material.color = colorToTurnTo;
            onground = false;
        }
        if (Input.GetKeyDown(dropBomb))
        {
            hasBomb = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (onground == true)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                hasBomb = true;
                Destroy(collision.gameObject);
            }
        }
      if (collision.gameObject.tag == "border")
        {
            Destroy(this.gameObject);
        } 
       
    }
}

