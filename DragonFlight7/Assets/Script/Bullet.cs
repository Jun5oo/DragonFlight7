using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody2D rb;

    [SerializeField] GameObject explosionEffect; 


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        rb.linearVelocity = Vector2.up * speed;
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameObject go = Instantiate(explosionEffect, collision.transform.position, Quaternion.identity);
            Destroy(go, 1); 

            Destroy(this); 
        }
    }
}
