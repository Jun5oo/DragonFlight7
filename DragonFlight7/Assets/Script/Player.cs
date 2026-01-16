using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        transform.Translate(distanceX, 0, 0); 
    }
}
