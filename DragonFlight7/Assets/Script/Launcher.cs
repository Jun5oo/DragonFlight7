using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float delay; 

    void Start()
    {
        delay = 0.1f; 

        InvokeRepeating("Shoot", 0f, delay);     
    }

    void Shoot()
    {
        AudioManager.instance.SoundExplosion();
        Instantiate(bullet, transform.position, Quaternion.identity); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
