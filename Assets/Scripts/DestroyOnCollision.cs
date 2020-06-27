using UnityEngine;
using System.Collections;


public class DestroyOnCollision : MonoBehaviour
{
    public AudioClip collectSound;

    public ParticleSystem burstingParticle;

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        burstingParticle = GetComponent<ParticleSystem>();
    }

    void OnCollisionEnter(Collision col)
    {

        // source.PlayOneShot(collectSound, 1F);
        
        source.Play();
        burstingParticle.Play();
        Destroy(gameObject, 0.5F);

    }
}
