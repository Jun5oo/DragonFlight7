using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] AudioSource myAudio;
    public AudioClip soundExplosion;
    public AudioClip soundDie; 

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Start()
    {
        myAudio = GetComponent<AudioSource>(); 
    }

    private void Update()
    {
        
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie); 
    }

    public void SoundExplosion()
    {
        myAudio.PlayOneShot(soundExplosion);
    }

}
