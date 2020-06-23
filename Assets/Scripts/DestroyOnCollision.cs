using UnityEngine;
using System.Collections;


public class DestroyOnCollision : MonoBehaviour
{
    public AudioClip collectSound;

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {

        source.PlayOneShot(collectSound, 1F);
      
        Destroy(gameObject, collectSound.length);

        



    }
}
