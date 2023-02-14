using UnityEngine;
using UnityEngine.SceneManagement;

public class dolphin : MonoBehaviour
{
    Vector3 dir;
    [SerializeField]
    Transform lookat;
    [SerializeField]
    Transform dolpin;
    [SerializeField]
    GameObject bomba;
    Animator animator;
    private Renderer rend;
    public bool onground = true;
    public bool hasBomb = false; //if dolphin has a bomb
    [SerializeField]
    private Color colorToTurnTo = Color.white;
    private KeyCode dropBomb = KeyCode.Q;
    public LookAtScript lookAtScript;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Släppa bomben
        animator.SetBool("hasBomb", hasBomb);
        dir = (dolpin.transform.position - lookat.transform.position).normalized;
        if (hasBomb == true & Input.GetKeyDown(dropBomb)) // Keybind för att släppa bomben.
        {
            Instantiate(bomba, dolpin.transform.position + dir * 3, Quaternion.identity);
            hasBomb = false;
        }
        // Immortality easter egg
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            rend.material.color = colorToTurnTo;
            onground = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kollar om man är på marken, inte har en bomb och om man colliderar med en Bomb. - Emil
        if (collision.gameObject.tag == "Bomb" & onground == true & hasBomb == false)
        {
            // Gör boolen "hasBomb" till sant.
            hasBomb = true;
            // Raderar bomben
            Destroy(collision.gameObject);
        }
        // om man kolliderar med fienden så spelas dödsanimationen och poängen och dashes blir reset. - adrian
        if (collision.gameObject.tag == "Enemy")
        {
            animator.ResetTrigger("Die");
            animator.SetTrigger("Die");
            pointcounter.score = 0;
            LookAtScript.dashAmount = 3;
            LookAtScript.speed = 0;
            Invoke("GameOver", 2);
        }
    }
    // Skickas till game over skärmen.
    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}

