using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1.3f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceY = moveSpeed * Time.deltaTime;
        transform.Translate(0, -distanceY, 0); 
    }

    // CTRL + SHIT + M = 유니티 함수 생성 
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Bullet"))
        {
            AudioManager.instance.SoundDie();
            Destroy(gameObject); 
        }

        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject); 
        }
    }


}
