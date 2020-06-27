using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField] private ParticleSystem burstingParticlePrefab;
    
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        source.Play();
        burstingParticlePrefab.Play();
        Destroy(gameObject, 0.5F);
    }
}
