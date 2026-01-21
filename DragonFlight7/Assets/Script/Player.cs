using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;
    [SerializeField] Rigidbody2D rb; 
    
    void Start()
    {
        rb.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float distanceX = Input.GetAxis("Horizontal") * moveSpeed;
        rb.linearVelocity = new Vector2 (distanceX, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
