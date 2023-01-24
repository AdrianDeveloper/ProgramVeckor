using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LookAtScript : MonoBehaviour
{
     
    Vector3 dir;
    [SerializeField]
    TextMeshProUGUI dashtext; //the text showing dash amount
    [SerializeField]
    public static float speed = 5;
    [SerializeField]
    Transform dolphinPos;
    [SerializeField]
    Transform LookAtDelfin;
    [SerializeField]
    private KeyCode Left = KeyCode.A; //key that turns left
    [SerializeField]
    private KeyCode Right = KeyCode.D; //key that turns right
    public static float dashAmount = 3; //amount of dashes

    TextMeshProUGUI dashAmountText;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        dashtext.text = "Dashes remaining: " + dashAmount; //dash amount
        if (Input.GetKey(Left)) // left rotation
        {
            transform.RotateAround(dolphinPos.transform.position, Vector3.forward, 100 * Time.deltaTime);
        }
        dir = (LookAtDelfin.transform.position - dolphinPos.transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
        if (Input.GetKey(Right)) //right rotation
        {
            transform.RotateAround(dolphinPos.transform.position, Vector3.back, 100 * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) && dashAmount > 0 ) //dash function
        {
            StartCoroutine(dash());
        }
    }
    //border bounce trigger V
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border") 
        {
            StartCoroutine(pushBack());
           
        } 
    }
    // Border Bounce V
    IEnumerator pushBack()
    {
        speed = -5;
        yield return new WaitForSeconds(1);
        speed = 5;
    }
   // Dash V
    IEnumerator dash()
    {
        dashAmount -= 1; 
        speed = 10;
        yield return new WaitForSeconds(2);
        speed = 5;
    }
}

