using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField] private ParticleSystem burstingParticle;
    
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        source.Play();
        burstingParticle.Play();
        Destroy(gameObject, 0.5F);
    }
}
