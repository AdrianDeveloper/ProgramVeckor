using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dolphin : MonoBehaviour
{
    Vector3 dir;
    [SerializeField]
    Transform dolpin;
    [SerializeField]
    GameObject bomba;
    Animator animator;
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
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (hasBomb == true & Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(bomba, dolpin.transform.position + dir, Quaternion.identity);
            hasBomb = false;
        }
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
        animator.SetBool("hasBomb", hasBomb);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (onground == true)
        {
            
            
                if (collision.gameObject.tag == "Bomb")
                {
                    hasBomb = true;
                    Destroy(collision.gameObject);
                }
            
        }
    
       
    }
}

