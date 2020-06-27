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

        var burstingParticle = GameObject.Instantiate(burstingParticlePrefab);      
        
        burstingParticle.Play();

        Destroy(burstingParticle.gameObject, burstingParticle.main.duration);
        
        Destroy(gameObject, 0.5F);
    }
}
