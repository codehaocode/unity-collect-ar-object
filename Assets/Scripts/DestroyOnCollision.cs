using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
 

    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
}
