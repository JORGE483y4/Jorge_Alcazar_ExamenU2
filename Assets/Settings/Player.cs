using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rb;
    
    private Vector2 direccionActual = Vector2.left;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            direccionActual = Vector2.up; 
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            direccionActual = Vector2.down; 
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direccionActual = Vector2.left; 
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            direccionActual = Vector2.right;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = direccionActual * velocidad;
    } private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ZonaDaño") || collision.gameObject.name == "Muro_Muerte")
        {
            Debug.Log("¡El jugador chocó con el muro de muerte y desapareció!");
            Destroy(gameObject);
        }
    }
}
