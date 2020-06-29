using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField] private int scoreYouGet = 0;
    [SerializeField] private ParticleSystem burstingParticlePrefab;    
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        
        ScoreManager.Instance.AddScore(scoreYouGet);
        source.Play();

        GameObject.Instantiate(burstingParticlePrefab, col.transform.position, Quaternion.identity);
      
        gameObject.GetComponent<Rigidbody>().useGravity = true;

        Destroy(gameObject, 0.5F);

        GameManager.Instance.SpawnObject();
    }
}
